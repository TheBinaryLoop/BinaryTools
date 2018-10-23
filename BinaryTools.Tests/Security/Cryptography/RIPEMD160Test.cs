using BinaryTools.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTools.Tests.Security.Cryptography
{
    [TestClass]
    public class RIPEMD160Test
    {
        [TestMethod]
        public void TestComputeHashFromString()
        {
            string testString = "This is the test string";
            Assert.AreEqual(RIPEMD160.ComputeHash(testString), "261733CAE4EBD91AE9603C0804F0BF6F96EDCF0A");
        }
    }
}
