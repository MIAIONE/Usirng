using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvm.Kernel.Registers
{
    internal interface IRegister<T>
    {
        public void Push(T obj);
        public T Pop();
    }
}
