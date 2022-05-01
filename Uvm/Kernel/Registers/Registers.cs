using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Uvm.Kernel.Types;

namespace Uvm.Kernel.Registers
{
    internal class Registers
    {
        public class BaseAddressRegister : RegisterBase<IntPtr>{ }
        public class AddressRegister : RegisterBase<IntPtr>{ }
        public class DataRegister : RegisterBase<byte[]> { }
        public class ProgramCountRegister : RegisterBase<long> { }
        public class LogicRegister : RegisterBase<OpCodes> { }
    }
}
