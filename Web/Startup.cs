﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Web.Startup))]
namespace Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // hub wire up and configurations
            app.MapSignalR();
        }
    }
}