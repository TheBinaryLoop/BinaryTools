using System;
using System.Runtime.InteropServices;
using System.Security;

namespace BinaryTools.Helpers
{
    /// <summary>
    /// Helper class for dealing with the securestring type
    /// </summary>
    public static class SecureStringHelper
    {
        /// <summary>
        /// Converts a <see cref="string"/> into a <see cref="SecureString"/>.
        /// </summary>
        /// <param name="plainString"></param>
        /// <returns></returns>
        public static SecureString CreateSecureString(string plainString)
        {
            SecureString secureString = new SecureString();
            if (plainString.Length > 0)
            {
                foreach (char c in plainString.ToCharArray())
                {
                    secureString.AppendChar(c);
                }
            }
            return secureString;
        }

        /// <summary>
        /// Converts a <see cref="SecureString"/> into a <see cref="string"/>.
        /// </summary>
        /// <param name="secureString"></param>
        /// <returns></returns>
        public static string CreateString(SecureString secureString)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

    }
}
