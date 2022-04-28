using Uvm.Kernel.Permissions;

namespace Uvm.Kernel.Memory
{
    internal static class MemoryStruct
    {
        [Ring(Access.Ring0)]
        public struct MemoryBlock
        {
            public IntPtr Ptr;
            public int Offset;
            public int Size;
            public MemoryType Type;
            public Access Access;
            
        }
        [Ring(Access.Ring0)]
        public enum MemoryType
        {
            Allocate,
            Device,
            Cacheable,
            Bufferable
        }
    }
}
