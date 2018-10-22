using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BinaryTools.Security.Cryptography
{

    /// <summary>
    /// A collection of helpful methods to simplify the use of the RIPEMD160 hash algorithm.
    /// </summary>
    public static class RIPEMD160
    {

        /// <summary>
        /// Computes the hash value for the specified string. 
        /// </summary>
        /// <param name="input">The input to compute the hash code for.</param>
        /// <returns>Returns the calculated hash value in the form of a hexadecimal string.</returns>
        public static string ComputeHash(string input)
        {
            RIPEMD160Managed module = new RIPEMD160Managed();
            byte[] output = module.ComputeHash(Encoding.UTF8.GetBytes(input));
            return output.Aggregate(new StringBuilder(output.Length * 2), (sb, b) => sb.AppendFormat("{0:X2}", b)).ToString();
        }
    }
}
