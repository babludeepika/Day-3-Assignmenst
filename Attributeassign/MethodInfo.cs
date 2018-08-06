using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributeassign
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method |
        AttributeTargets.Constructor |
        AttributeTargets.Property, AllowMultiple = true)]
    class MethodInfo : Attribute
    {
        public string methodname { get; set; }
        public string returntype { get; set; }
        public string parameters { get; set; }
        public string message { get; set; }

    }
}
