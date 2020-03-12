using BlazorSignalR.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using BlazorSignalR.Server.Services;

namespace BlazorSignalR.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> logger;
        private readonly WeatherForecastService weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastService weatherService)
        {
            this.logger = logger;
            this.weatherService = weatherService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return weatherService.Get();
        }
    }
}
