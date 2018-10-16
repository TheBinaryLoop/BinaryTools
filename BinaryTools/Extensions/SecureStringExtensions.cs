using System;
using System.Runtime.InteropServices;
using System.Security;

namespace BinaryTools.Extensions {

   /// <summary>
   /// A collection of helpful extension methods for the <see cref="SecureString"/> class
   /// </summary>
   public static class SecureStringExtensions {

      public static string ToUnsecureString(this SecureString secStr) {
         IntPtr unmanagedString = IntPtr.Zero;
         try {
            unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secStr);
            return Marshal.PtrToStringUni(unmanagedString);
         }
         finally {
            Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
         }
      }

   }
}
