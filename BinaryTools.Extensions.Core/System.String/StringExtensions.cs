using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BinaryTools.Extensions.Core
{

    /// <summary>
    /// A collection of helpful extension methods for the <see cref="string"/> class.
    /// </summary>
    public static partial class StringExtensions
    {

        /// <summary>
        /// Replaces placeholders inside a <see cref="string"/> with specified values.
        /// </summary>
        /// <param name="str">The string that contains the placeholders.</param>
        /// <param name="args">The placeholders and actual values to replace them with.</param>
        /// <returns></returns>
        public static string Format(this string str, params Expression<Func<string, object>>[] args)
        {
            Dictionary<string, object> parameters = args.ToDictionary(e => string.Format("{{{0}}}", e.Parameters[0].Name), e => e.Compile()(e.Parameters[0].Name));

            StringBuilder sb = new StringBuilder(str);
            foreach (KeyValuePair<string, object> kv in parameters)
            {
                sb.Replace(kv.Key, kv.Value != null ? kv.Value.ToString() : "");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Converts the hexadecimal string to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="value">The hexadecimal string.</param>
        /// <returns>A 32-bit signed integer equivalent to the hexadecimal string.</returns>
        public static Int32 FromHex(this string value)
        {
            // strip the leading 0x
            if (value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                value = value.Substring(2);
            }
            return Int32.Parse(value, NumberStyles.HexNumber);
        }

        /// <summary>
        /// Compresses the given string with GZip into a byte array.
        /// </summary>
        /// <param name="str">The string to act on.</param>
        /// <returns>The string compressed into a GZip byte array.</returns>
        public static byte[] CompressGZip(this string str)
        {
            byte[] stringAsBytes = Encoding.Default.GetBytes(str);
            using (var memoryStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                    zipStream.Close();
                    return (memoryStream.ToArray());
                }
            }
        }

        /// <summary>
        /// Compresses the given string with GZip into a byte array.
        /// </summary>
        /// <param name="str">The string to act on.</param>
        /// <param name="encoding">The <see cref="Encoding"/> to use.</param>
        /// <returns>The string compressed into a GZip byte array.</returns>
        public static byte[] CompressGZip(this string str, Encoding encoding)
        {
            byte[] stringAsBytes = encoding.GetBytes(str);
            using (var memoryStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                    zipStream.Close();
                    return (memoryStream.ToArray());
                }
            }
        }

    }
}
