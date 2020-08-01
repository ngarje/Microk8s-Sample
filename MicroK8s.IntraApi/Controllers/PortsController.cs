using MicroK8s.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MicroK8s.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PortsController : ControllerBase
    {
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

            return CountryModel.Countries.Where(CountryNameClause).Where(CountryCodeClause).Skip((page.Value -1) * pageSize.Value).Take(pageSize.Value).OrderBy(x=>x.Name).ToList();
        }    
    }
}