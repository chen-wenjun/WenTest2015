using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET.Mvc.SignalR
{
    [HubName("myHub")]
    public class MyHub : Hub
    {
        [HubMethodName("send")]
        public void Send(string message)
        {
            Clients.All.Push(message);
        }

        public DateTime GetServerTime()
        {
            return DateTime.Now;
        }


    }
}