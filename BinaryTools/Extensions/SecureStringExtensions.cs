using System.Security;
using BinaryTools.Helpers;

namespace BinaryTools.Extensions
{

    /// <summary>
    /// A collection of helpful extension methods for the <see cref="SecureString"/> class
    /// </summary>
    public static class SecureStringExtensions
    {

        /// <summary>
        /// Converts a <see cref="SecureString"/> into a <see cref="string"/>.
        /// </summary>
        /// <param name="secStr"></param>
        /// <returns></returns>
        public static string ToUnsecureString(this SecureString secStr)
        {
            return SecureStringHelper.CreateString(secStr);
        }

    }
}
