using System;

namespace BinaryTools.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="int"/> class.
    /// </summary>
    public static class IntegerExtensions
    {
        public static string ToHex(this int value)
        {
            return String.Format("0x{0:X}", value);
        }
    }
}
