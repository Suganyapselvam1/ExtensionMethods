using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodLibrary
{
    class TargetTest
    {
        [Test]
        public  void StandardizedId()
        {
            var obj = new Target("id01");
            Assert.AreEqual("id01", obj.GetStandardizedId());
        }
    }
}
