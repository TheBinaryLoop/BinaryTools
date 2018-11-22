using System.IO;
using System.Security.Cryptography;

namespace BinaryTools.Extensions.IO
{
    /// <summary>
    /// A collection of helpful extension methods for the <see cref="FileStream"/> class.
    /// </summary>
    public static partial class FileStreamExtensions
    {

        /// <summary>
        /// Computes the SHA512 hash code for the current filestream.
        /// </summary>
        /// <param name="fileStream">The FileStream to act on.</param>
        /// <returns>Returns the computed hash code as a string.</returns>
        public static string GetSHA512Hash(FileStream fileStream)
        {
            SHA512 sha512 = SHA512.Create();
            byte[] bytes = sha512.ComputeHash(fileStream);
            string result = "";
            foreach (byte b in bytes)
            {
                result += b.ToString("x2");
            }
            return result;
        }

    }
}
