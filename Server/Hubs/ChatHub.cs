using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace DirectBusiness.Server.Hubs
{
    public class ChatHub : Hub
    {
        public const string HubUrl = "/chathub";
        public async Task SendMessage(string remetente, string destinatario, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", remetente, destinatario, message);
        }
    }
}