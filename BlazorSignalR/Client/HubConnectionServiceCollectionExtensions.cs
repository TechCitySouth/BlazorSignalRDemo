using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSignalR.Client
{
    public static class HubConnectionServiceCollectionExtensions
    {
        public static IServiceCollection AddHubConnection(this IServiceCollection serviceCollection, out HubConnection hubConnection)
        {
            // Temporary workaround as we don't provide a good way to get the base address when setting up the host
            var navigationManager = serviceCollection.BuildServiceProvider().GetService<NavigationManager>();

            hubConnection = new HubConnectionBuilder()
                .WithUrl(navigationManager.ToAbsoluteUri("/appHub"))
                .AddMessagePackProtocol()
                .Build();

            return serviceCollection.AddSingleton(hubConnection);
        }
    }
}
