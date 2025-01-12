﻿using Contracts;
using Microsoft.Extensions.DependencyInjection;
using ServiceImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceImplementation
{
    public class OverridePluginConfiguration : IPluginFactory
    {
        public void Configure(IServiceCollection services)
        {
            //this service override the standard one. unload this plugin or comment this to use the basic service
            services.AddSingleton<IFruitService, OverrideFruiteService>();
        }
    }
}
