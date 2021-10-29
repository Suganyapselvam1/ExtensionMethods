using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodLibrary
{
    public class Target
    {
        private string _id;
        protected string Id
        { 
            get { return _id; }
            set { _id = value.Trim(); }
        }
        public string GetId()
        {
            return _id;
        }
        public Target(string Id)
        {
            _id = Id;
        }
        public string GetStandardizedId()
        {
            return _id.ToLower();
        }
    }

    internal class InternalTarget
    {
        protected class ProtectedSubClass { }
    }
}
