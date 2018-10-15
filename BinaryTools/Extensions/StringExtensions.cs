using System;

namespace BinaryTools.Extensions {
   public static class StringExtensions {

      public static string GetSHA256Hash(this String str) {
         return Security.Cryptography.SHA256.GetSHA256Hash(str);
      }
   }
}
