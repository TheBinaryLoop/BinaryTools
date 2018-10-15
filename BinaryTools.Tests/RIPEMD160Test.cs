using BinaryTools.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTools.Tests {
   [TestClass]
   public class RIPEMD160Test {
      [TestMethod]
      public void TestGetRIPEMD160Hash() {
         string testString = "This is the test string";
         Assert.AreEqual(RIPEMD160.GetRIPEMD160Hash(testString), "261733CAE4EBD91AE9603C0804F0BF6F96EDCF0A");
      }
   }
}
