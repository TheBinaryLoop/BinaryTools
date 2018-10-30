using System;

namespace BinaryTools.Extensions
{
    public static class IntegerExtensions
    {
        public static string ToHex(this int value)
        {
            return String.Format("0x{0:X}", value);
        }
    }
}
