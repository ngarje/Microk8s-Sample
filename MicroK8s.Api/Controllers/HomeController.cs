using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Policy;

namespace MicroK8s.IntraApi.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/Home
        [HttpGet]
        public object Get()
        {
            var baseUrl = new Uri($"{this.Request.Scheme}://{Request.Host.Value}{this.Request.PathBase.Value}");
            return new
            {
                hostInfo = GetHostInfo(),
                name = Assembly.GetExecutingAssembly().FullName,
                controllerUrl = new string[] {
                new Uri(baseUrl,"WeatherForecast").ToString(),
                new Uri(baseUrl,"Countries").ToString(),
            }
            };
        }

        private string GetHostInfo()
        {
            string result = "UNKNOWN";
            try
            {
                result = Dns.GetHostName().ToUpperInvariant();
                IPAddress[] ipaddress = Dns.GetHostAddresses(result);
                result += " : " + string.Join("; ", ipaddress.Select(x => x.ToString())); ;
            }
            catch
            {
                // do nothing
            }
            return result;
        }
    }
}