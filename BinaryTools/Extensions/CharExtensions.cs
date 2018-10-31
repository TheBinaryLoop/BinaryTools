using System;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Enumerates from current char to toCharacter.
        /// </summary>
        /// <param name="src">The char to act on.</param>
        /// <param name="toCharacter">Target character.</param>
        /// <returns>An enumerator that allows loops to be used to process src to toCharacter.</returns>
        public static IEnumerable<Char> To(this Char src, Char toCharacter)
        {
            bool reverseRequired = (src > toCharacter);

            Char first = reverseRequired ? toCharacter : src;
            Char last = reverseRequired ? src : toCharacter;

            IEnumerable<Char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (Char)charCode);

            if (reverseRequired)
            {
                result = result.Reverse();
            }

            return result;
        }

    }
}
