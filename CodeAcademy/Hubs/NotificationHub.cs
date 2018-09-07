using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Hubs
{
    public class NotificationHub: Hub
    {
        public async Task Notify()
        {
            await Clients.All.ShowNotification();
        }
    }
}
