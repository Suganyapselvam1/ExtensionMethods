using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodLibrary
{
    public static class TargetExtension
    {
        internal static void ExtendInternal(this InternalTarget target)
        {

        }
        //internal static void ExtendInternalProtected(this InternalTarget.ProtectedSubClass target)
        //{

        //}
        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();
        }
    }
}
