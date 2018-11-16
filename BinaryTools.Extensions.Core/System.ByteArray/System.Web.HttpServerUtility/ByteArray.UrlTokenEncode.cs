#if !NETSTANDARD
using System;
using System.Web;

namespace BinaryTools.Extensions.Core
{
    public static partial class ByteArrayExtensions
    {
        /// <summary>
        /// Encodes a byte array into its equivalent string representation using base 64 digits, which is usable for transmission on the URL.
        /// </summary>
        /// <param name="input">The byte array to encode.</param>
        /// <returns>The string containing the encoded token if the byte array length is greater than one; otherwise, an empty string ("").</returns>
        public static String UrlTokenEncode(this Byte[] input)
        {
            return HttpServerUtility.UrlTokenEncode(input);
        }
    }
}
#endif
