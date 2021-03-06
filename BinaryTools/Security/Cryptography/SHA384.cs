﻿using System.Linq;
using System.Security.Cryptography;
using System.Text;

#if !NETSTANDARD1_3

namespace BinaryTools.Security.Cryptography
{

    /// <summary>
    /// A collection of helpful methods to simplify the use of the SHA384 hash algorithm.
    /// </summary>
    public static class SHA384
    {

        /// <summary>
        /// Computes the hash value for the specified string. 
        /// </summary>
        /// <param name="input">The input to compute the hash code for.</param>
        /// <returns>Returns the calculated hash value in the form of a hexadecimal string.</returns>
        public static string ComputeHash(string input)
        {
            SHA384Managed module = new SHA384Managed();
            byte[] output = module.ComputeHash(Encoding.UTF8.GetBytes(input));
            return output.Aggregate(new StringBuilder(output.Length * 2), (sb, b) => sb.AppendFormat("{0:X2}", b)).ToString();
        }
    }
}

#endif
