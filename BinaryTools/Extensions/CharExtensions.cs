using System;

namespace BinaryTools.Extensions
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="Char"/> class.
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        /// Repeats a character the specified number of times.
        /// </summary>
        /// <param name="src">The char to act on.</param>
        /// <param name="repeatCount">The number of repeats.</param>
        /// <returns>A string containing the repeated char.</returns>
        public static String Repeat(this Char src, Int32 repeatCount)
        {
            return new String(src, repeatCount);
        }

    }
}
