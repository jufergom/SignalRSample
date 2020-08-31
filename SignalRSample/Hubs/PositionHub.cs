using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRSample.Hubs
{
    public class PositionHub : Hub
    {
        public async Task SendPosition(int left, int top)
        {
            //others: send to everyone except me
            await Clients.Others.SendAsync("ReceivePosition", left, top);
        }
    }
}
