using System.Security;

namespace BinaryTools.Extensions {
   public static class StringExtensions {

      public static string GetRIPEMD160Hash(this string str) {
         return Security.Cryptography.RIPEMD160.ComputeHash(str);
      }

      public static string GetSHA1Hash(this string str) {
         return Security.Cryptography.SHA1.ComputeHash(str);
      }

      public static string GetSHA256Hash(this string str) {
         return Security.Cryptography.SHA256.ComputeHash(str);
      }

      public static string GetSHA384Hash(this string str) {
         return Security.Cryptography.SHA384.ComputeHash(str);
      }

      public static SecureString ToSecureString(this string str) {
         SecureString secureString = new SecureString();
         if (str.Length > 0) {
            foreach (char c in str.ToCharArray()) {
               secureString.AppendChar(c);
            }
         }
         return secureString;
      }
   }
}
