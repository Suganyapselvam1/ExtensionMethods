﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodLibrary
{
    public static class ConfigurationExtension
    {
        public static bool IsLoaded(this IConfiguration config)
        {
            return config!=null && config.AsEnumerable().Any();
        }
        public static IConfigurationBuilder AddStandardProviders(this IConfigurationBuilder configBuilder)
        {

            return configBuilder.AddJsonFile("appsettings.json").AddEnvironmentVariables().AddJsonFile("config/config.json",optional:true).AddJsonFile("secrets/secrets.json", optional: true);
        }
    }
}
