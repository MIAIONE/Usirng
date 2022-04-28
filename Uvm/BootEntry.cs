using System.Text;
using Uvm.Kernel.Memory;
using Uvm.Kernel.Permissions;

namespace Uvm
{
    public class BootEntry
    {
        public static void DbMem()
        {
            var mem = new MemoryManager();
            mem.Allocate(14, 0, MemoryStruct.MemoryType.Bufferable, Access.Ring0, out Span<byte> buffer1);
            Encoding.UTF8.GetBytes("hello world!").CopyTo(buffer1);
            Console.ReadKey();
            Console.WriteLine(Encoding.UTF8.GetString(buffer1));

            //mem.Release(ptr);
            mem.Dispose();
        }
    }
}