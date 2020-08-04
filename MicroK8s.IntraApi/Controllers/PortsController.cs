using MicroK8s.Api.Models;
using Microsoft.AspNetCore.Mvc;
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
    public class PortsController : ControllerBase
    {
        private readonly IDistributedCache cacheManager;
        public PortsController(IDistributedCache cacheManager)
        {
            this.cacheManager = cacheManager;
        }
        [HttpGet]
        public IEnumerable<CountryModel> GetAirports(int? page, int? pageSize, string name = null, string code = null)
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

            return GetPortsList().Where(CountryNameClause).Where(CountryCodeClause).Skip((page.Value -1) * pageSize.Value).Take(pageSize.Value).OrderBy(x=>x.Name).ToList();
        }

        private List<CountryModel> GetPortsList()
        {
            string cacheKey = "port-list";
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
                countryList = CountryModel.Countries;
                countryList.ForEach(x => x.CachedTime = DateTime.Now);
                serializedCountries = JsonConvert.SerializeObject(countryList);
                encodedCountries = Encoding.UTF8.GetBytes(serializedCountries);
                var options = new DistributedCacheEntryOptions()
                                    .SetSlidingExpiration(TimeSpan.FromMinutes(5))
                                    .SetAbsoluteExpiration(DateTime.Now.AddDays(6));
                cacheManager.Set(cacheKey, encodedCountries, options);

            }
            return countryList;
        }
    }
}