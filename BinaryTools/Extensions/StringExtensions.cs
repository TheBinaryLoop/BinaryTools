using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using BinaryTools.Helpers;

namespace BinaryTools.Extensions
{

    /// <summary>
    /// A collection of helpful extension methods for the <see cref="string"/> class.
    /// </summary>
    public static class StringExtensions
    {

        /// <summary>
        /// Computes the <see cref="System.Security.Cryptography.RIPEMD160"/> hash for this <see cref="string"/>.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetRIPEMD160Hash(this string str)
        {
            return Security.Cryptography.RIPEMD160.ComputeHash(str);
        }

        /// <summary>
        /// Computes the <see cref="System.Security.Cryptography.SHA1"/> hash for this <see cref="string"/>.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetSHA1Hash(this string str)
        {
            return Security.Cryptography.SHA1.ComputeHash(str);
        }

        /// <summary>
        /// Computes the <see cref="System.Security.Cryptography.SHA256"/> hash for this <see cref="string"/>.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetSHA256Hash(this string str)
        {
            return Security.Cryptography.SHA256.ComputeHash(str);
        }

        /// <summary>
        /// Computes the <see cref="System.Security.Cryptography.SHA384"/> hash for this <see cref="string"/>.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetSHA384Hash(this string str)
        {
            return Security.Cryptography.SHA384.ComputeHash(str);
        }

        /// <summary>
        /// Converts a <see cref="string"/> into a <see cref="SecureString"/>.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static SecureString ToSecureString(this string str)
        {
            return SecureStringHelper.CreateSecureString(str);
        }

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
        /// Converts a hexadecimal string into a <see cref="Int32"/>.
        /// </summary>
        /// <param name="value">The hexadecimal string.</param>
        /// <returns></returns>
        public static Int32 FromHex(this string value)
        {
            // strip the leading 0x
            if (value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                value = value.Substring(2);
            }
            return Int32.Parse(value, NumberStyles.HexNumber);
        }
    }
}
