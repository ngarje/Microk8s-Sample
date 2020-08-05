using AgileObjects.AgileMapper;
using AgileObjects.AgileMapper.Extensions;
using MicroK8s.Api.Database.Context;
using MicroK8s.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroK8s.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly  IDistributedCache cacheManager;
        private readonly EfContext efContext;
        public CountriesController(IDistributedCache cacheManager, EfContext efContext)
        {
            this.cacheManager = cacheManager;
            this.efContext = efContext;
        }
        [HttpGet]
        public IActionResult GetCountries(int? page, int? pageSize, string name = null, string code = null)
        {
            bool CountryNameClause(CountryModel m) {
                return string.IsNullOrWhiteSpace(name) ? true : m.Name.ToLowerInvariant().Contains(name.ToLowerInvariant());
            }

            bool CountryCodeClause(CountryModel m)
            {
                return string.IsNullOrWhiteSpace(code) ? true : m.Code.ToLowerInvariant().StartsWith(code.ToLowerInvariant());
            }
            page = !page.HasValue ? 1 : Math.Max(page.Value, 1);
            pageSize = !pageSize.HasValue ? 10 : pageSize;
            try
            {
                return Ok(GetCountryList()
                    .Where(CountryNameClause)
                    .Where(CountryCodeClause)
                    .OrderByDescending(x => x.ModifiedDate).ThenBy(x=>x.Name)
                    .Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value).ToList());

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.StackTrace, title: ex.Message);
            }
        }


        private List<CountryModel> GetCountryList()
        {
            string cacheKey = "country-list";
            string serializedCountries;
            var encodedCountries = cacheManager.Get(cacheKey);
            List<CountryModel> countryList;
            if (encodedCountries != null)
            {
                serializedCountries = Encoding.UTF8.GetString(encodedCountries);
                countryList = JsonConvert.DeserializeObject<List<CountryModel>>(serializedCountries);
            }
            else
            {
                var countryDbList = efContext.CountryTable.Include(x=>x.Region).ToList();
                countryList = Mapper.Map(countryDbList).ToANew<List<CountryModel>>();
                countryList.ForEach(x => x.CachedTime = DateTime.Now);
                serializedCountries = JsonConvert.SerializeObject(countryList);
                encodedCountries = Encoding.UTF8.GetBytes(serializedCountries);
                var options = new DistributedCacheEntryOptions()
                                    .SetSlidingExpiration(TimeSpan.FromMinutes(60))
                                    .SetAbsoluteExpiration(DateTime.Now.AddDays(6));
                cacheManager.Set(cacheKey, encodedCountries, options);

            }
            return countryList;
        }
    }
}