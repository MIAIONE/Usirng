using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvm.Kernel.Registers
{
    internal class Register : IRegister<byte>
    {
        public byte Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(byte obj)
        {
            throw new NotImplementedException();
        }
    }
}
