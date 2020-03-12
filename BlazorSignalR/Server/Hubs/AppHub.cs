using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagePack;
using Microsoft.AspNetCore.SignalR;
using BlazorSignalR.Shared;
using BlazorSignalR.Server.Services;

namespace BlazorSignalR.Server.Hubs
{
    public class AppHub : Hub
    {
        private readonly WeatherForecastService weatherService;

        public AppHub(WeatherForecastService weatherService)
        {
            this.weatherService = weatherService;
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public IEnumerable<WeatherForecast> GetWeather()
        {
            return weatherService.Get();
        }
    }
}