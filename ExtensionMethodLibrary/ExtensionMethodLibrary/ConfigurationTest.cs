using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodLibrary
{
    class ConfigurationTest
    {
        [Test]
        public void IsLoaded()
        {
            IConfiguration config = null;
            Assert.IsFalse(config.IsLoaded());
        }
    }
}
