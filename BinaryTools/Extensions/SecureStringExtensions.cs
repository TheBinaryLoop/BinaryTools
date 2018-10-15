using System;
using System.Runtime.InteropServices;
using System.Security;

namespace BinaryTools.Extensions {
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
