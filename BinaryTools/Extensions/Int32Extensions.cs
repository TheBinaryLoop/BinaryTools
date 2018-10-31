using System;

namespace BinaryTools.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Int32"/> class.
    /// </summary>
    public static class Int32Extensions
    {
        public static string ToHex(this Int32 value)
        {
            return String.Format("0x{0:X}", value);
        }
    }
}
