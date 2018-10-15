using System.Security;

namespace BinaryTools.Extensions {
   public static class StringExtensions {

      public static string GetSHA256Hash(this string str) {
         return Security.Cryptography.SHA256.GetSHA256Hash(str);
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
