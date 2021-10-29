using Microsoft.Extensions.Configuration;
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
    }
}
