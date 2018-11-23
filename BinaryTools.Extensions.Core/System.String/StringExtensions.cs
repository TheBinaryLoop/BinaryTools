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
        public static String Format(this String str, params Expression<Func<String, Object>>[] args)
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
        public static Int32 FromHex(this String value)
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
        public static Byte[] CompressGZip(this String str)
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
        public static Byte[] CompressGZip(this String str, Encoding encoding)
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

        /// <summary>
        /// Convert roman numerals to an integer.
        /// </summary>
        /// <param name="str">The string to act on.</param>
        /// <returns>Returns the roman string as integer.</returns>
        public static Int32 ToArabic(this String str)
        {
            // Initialize the letter map.
            Dictionary<char, int> CharValues = new Dictionary<char, int>();
            CharValues.Add('I', 1);
            CharValues.Add('V', 5);
            CharValues.Add('X', 10);
            CharValues.Add('L', 50);
            CharValues.Add('C', 100);
            CharValues.Add('D', 500);
            CharValues.Add('M', 1000);

            if (str.Length == 0) return 0;
            str = str.ToUpper();

            // See if the number begins with (.
            if (str[0] == '(')
            {
                // Find the closing parenthesis.
                int pos = str.LastIndexOf(')');

                // Get the value inside the parentheses.
                string part1 = str.Substring(1, pos - 1);
                string part2 = str.Substring(pos + 1);
                return 1000 * ToArabic(part1) + ToArabic(part2);
            }

            // The number doesn't begin with (.
            // Convert the letters' values.
            int total = 0;
            int last_value = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                int new_value = CharValues[str[i]];

                // See if we should add or subtract.
                if (new_value < last_value)
                    total -= new_value;
                else
                {
                    total += new_value;
                    last_value = new_value;
                }
            }

            // Return the result.
            return total;
        }

    }
}
