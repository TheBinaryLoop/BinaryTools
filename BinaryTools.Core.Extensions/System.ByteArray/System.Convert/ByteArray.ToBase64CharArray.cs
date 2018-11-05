using System;

namespace BinaryTools.Core.Extensions
{
    public static partial class ByteArrayExtensions
    {
        /// <summary>
        /// Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 
        /// digits. Parameters specify the subsets as offsets in the input and output arrays, and the number of elements in the input array to 
        /// convert.
        /// </summary>
        /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
        /// <param name="offsetIn">A position within inArray.</param>
        /// <param name="length">The number of elements of inArray to convert.</param>
        /// <param name="outArray">An output array of Unicode characters.</param>
        /// <param name="offsetOut">A position within outArray.</param>
        /// <returns>A 32-bit signed integer containing the number of bytes in outArray.</returns>
        public static Int32 ToBase64CharArray(this Byte[] inArray, Int32 offsetIn, Int32 length, Char[] outArray, Int32 offsetOut)
        {
            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut);
        }

        /// <summary>
        /// Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 
        /// digits. Parameters specify the subsets as offsets in the input and output arrays, the number of elements in the input array to 
        /// convert, and whether line breaks are inserted in the output array.
        /// </summary>
        /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
        /// <param name="offsetIn">A position within inArray.</param>
        /// <param name="length">The number of elements of inArray to convert.</param>
        /// <param name="outArray">An output array of Unicode characters.</param>
        /// <param name="offsetOut">A position within outArray.</param>
        /// <param name="options">InsertLineBreaks to insert a line break every 76 characters, or None to not insert line breaks.</param>
        /// <returns>A 32-bit signed integer containing the number of bytes in outArray.</returns>
        public static Int32 ToBase64CharArray(this Byte[] inArray, Int32 offsetIn, Int32 length, Char[] outArray, Int32 offsetOut, Base64FormattingOptions options)
        {
            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options);
        }
    }
}
