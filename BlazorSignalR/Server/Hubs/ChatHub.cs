using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagePack;
using Microsoft.AspNetCore.SignalR;
using BlazorSignalR.Shared;

namespace BlazorSignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(byte[] msgpack)
        {
            MPClass.MyMessage mc2 = MessagePackSerializer.Deserialize<MPClass.MyMessage>(msgpack);
            await Clients.All.SendAsync("ReceiveMessage", msgpack);
        }
    }
}