using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvm.Kernel.Permissions
{
    [AttributeUsage(AttributeTargets.All)]
    internal class Ring : Attribute
    {
        public Ring(Access ring)
        {
            Access = ring;
        }

        public Access Access { get; }
    }
    public enum Access
    {
        Ring0,
        Ring1,
        Ring2,
        Ring3
    }
}
