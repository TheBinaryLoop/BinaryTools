using System;

namespace BinaryTools.Core.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Byte"/> class.
    /// </summary>
    public static partial class ByteExtensions
    {
        /// <summary>
        /// Returns the larger of two 8-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 8-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 8-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static Byte Max(this Byte val1, Byte val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        /// Returns the smaller of two 8-bit unsigned integers.
        /// </summary>
        /// <param name="val1">The first of two 8-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 8-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static Byte Min(this Byte val1, Byte val2)
        {
            return Math.Min(val1, val2);
        }

    }
}
