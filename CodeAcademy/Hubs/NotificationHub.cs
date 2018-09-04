﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Hubs
{
    public class NotificationHub:Hub
    {
        public async Task Notify(string message)  
        {
            await Clients.All.SendAsync("Notify", message);
        }
    }
}
