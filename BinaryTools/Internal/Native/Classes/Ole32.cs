using System;
using System.Runtime.InteropServices;

namespace BinaryTools.Internal.Native.Classes
{
    internal class Ole32
    {
        [DllImport("ole32.dll")]
        internal static extern void CoTaskMemFree(IntPtr ptr);
    }
}
