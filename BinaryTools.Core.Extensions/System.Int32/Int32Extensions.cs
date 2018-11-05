using System;

namespace BinaryTools.Core.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Int32"/> class.
    /// </summary>
    public static partial class Int32Extensions
    {
        /// <summary>
        /// Converts the numeric value of this instance to its equivalent hexadecimal representation.
        /// </summary>
        /// <param name="value">The Int32 to act on.</param>
        /// <returns>The hexadecimal representation of the value of this instance.</returns>
        public static string ToHex(this Int32 value)
        {
            return String.Format("0x{0:X}", value);
        }
    }
}
