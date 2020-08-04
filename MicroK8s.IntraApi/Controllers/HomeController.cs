using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Net;
using System.Reflection;

namespace MicroK8s.IntraApi.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IWebHostEnvironment env;
        private readonly IConfiguration config;

        public HomeController(IWebHostEnvironment env, IConfiguration config)
        {
            this.env = env;
            this.config = config;
        }
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

        private object GetHostInfo()
        {
            string result = "UNKNOWN";
            try
            {
                IPAddress[] ipaddress = Dns.GetHostAddresses(Dns.GetHostName());
                return new
                {
                    Environment.MachineName,
                    IPAddress = string.Join("; ", ipaddress.Select(x => x.ToString())),
                    env.EnvironmentName,
                    Redis__ConnectionString = config["Redis:ConnectionString"],
                    Redis__InstanceName = config["Redis:InstanceName"]

                };
            }
            catch
            {
                // do nothing
            }
            return result;
        }
    }
}