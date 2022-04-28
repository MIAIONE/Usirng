using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using Uvm.Kernel.Permissions;

namespace Uvm.Kernel.Memory
{
    internal class MemoryManager : IDisposable
    {
        //只需保存内存表即可，具体byte[]通过指针引用到实际内存
        private readonly ConcurrentDictionary<IntPtr, MemoryStruct.MemoryBlock> MemoryBlocks = new();
        [Ring(Access.Ring0)]
        public IntPtr Allocate(int size,int offset, MemoryStruct.MemoryType type, Access access, out Span<byte> bytes)
        {
            IntPtr ptr = IntPtr.Zero;
            try
            {
                ptr=Marshal.AllocHGlobal(size + offset);
                unsafe
                {
                    bytes = new Span<byte>((byte*)ptr, size + offset);
                }
                //一定要清除，分配后内存包含无用数据！
                bytes.Clear();
                var memStruct = new MemoryStruct.MemoryBlock
                {
                    Offset = offset,
                    Size = size,
                    Type = type,
                    Access = access,
                    Ptr = ptr
                };
                MemoryBlocks.AddOrUpdate(ptr, memStruct, (k, v) => { return v; });
            }
            catch
            {
                throw new Exception("Allocate RAM ERROR");
            }          
            return ptr;
        }
        [Ring(Access.Ring0)]
        public void Release(IntPtr ptr)
        {
            try
            {
                MemoryBlocks.Remove(ptr, out MemoryStruct.MemoryBlock descStruct);
                descStruct.Type = MemoryStruct.MemoryType.Allocate;
                descStruct.Access = Access.Ring0;
                descStruct.Size = 0;
                descStruct.Ptr = IntPtr.Zero;
                descStruct.Offset = 0;
                Marshal.FreeHGlobal(ptr);
            }
            catch
            {
                throw new Exception("Release RAM ERROR");
            }
             
        }
        [Ring(Access.Ring0)]
        public void Dispose()
        {
            foreach(KeyValuePair<IntPtr,MemoryStruct.MemoryBlock> memoryBlock in MemoryBlocks)
            {
                Release(memoryBlock.Key);
            }
            GC.Collect();
        }
    }
}
