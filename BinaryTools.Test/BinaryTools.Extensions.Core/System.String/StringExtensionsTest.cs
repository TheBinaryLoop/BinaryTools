using System.Linq;
using System.Text;
using BinaryTools.Extensions.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTools.Test.BinaryTools.Extensions.Core
{
    /// <summary>
    /// Summary description for StringExtensionsTest
    /// </summary>
    [TestClass]
    public class StringExtensionsTest
    {
        public StringExtensionsTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void FormatTest()
        {
            string test_string = "{test_value_1} test {test_value_2}";
            Assert.AreEqual(test_string.Format(
                test_value_1 => "TestValue1",
                test_value_2 => "TestValue2"
            ), "TestValue1 test TestValue2");
        }

        [TestMethod]
        public void FromHexTest()
        {
            Assert.AreEqual("0x64".FromHex(), 100);
        }

        [TestMethod]
        public void CompressGZipTest()
        {
            Assert.IsTrue("This will be compressed with GZip".CompressGZip().SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 201, 200, 44, 86, 40, 207, 204, 201, 81, 72, 74, 85, 72, 206, 207, 45, 40, 74, 45, 46, 78, 77, 1, 10, 149, 100, 40, 184, 71, 101, 22, 0, 0, 58, 161, 211, 97, 33, 0, 0, 0 }));
        }

        [TestMethod]
        public void CompressGZipWithASCIIEncodingTest()
        {
            Assert.IsTrue("This will be compressed with GZip".CompressGZip(Encoding.ASCII).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 201, 200, 44, 86, 40, 207, 204, 201, 81, 72, 74, 85, 72, 206, 207, 45, 40, 74, 45, 46, 78, 77, 1, 10, 149, 100, 40, 184, 71, 101, 22, 0, 0, 58, 161, 211, 97, 33, 0, 0, 0 }));
        }

        [TestMethod]
        public void CompressGZipWithBigEndianUnicodeEncodingTest()
        {
            Assert.IsTrue("This will be compressed with GZip".CompressGZip(Encoding.BigEndianUnicode).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 99, 8, 97, 200, 96, 200, 100, 40, 102, 80, 96, 40, 7, 210, 57, 64, 168, 192, 144, 196, 144, 10, 36, 147, 25, 242, 25, 114, 25, 10, 24, 138, 128, 188, 98, 32, 76, 101, 72, 129, 170, 42, 1, 234, 81, 96, 112, 103, 136, 2, 178, 11, 0, 182, 85, 117, 9, 66, 0, 0, 0 }));
        }

        [TestMethod]
        public void CompressGZipWithUnicodeEncodingTest()
        {
            Assert.IsTrue("This will be compressed with GZip".CompressGZip(Encoding.Unicode).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 97, 200, 96, 200, 100, 40, 102, 80, 96, 40, 7, 210, 57, 64, 168, 192, 144, 196, 144, 10, 36, 147, 25, 242, 25, 114, 25, 10, 24, 138, 128, 188, 98, 32, 76, 101, 72, 129, 170, 42, 1, 234, 81, 96, 112, 103, 136, 2, 178, 11, 24, 0, 56, 205, 9, 238, 66, 0, 0, 0 }));
        }

        [TestMethod]
        public void CompressGZipWithUTF32EncodingTest()
        {
            Assert.IsTrue("This will be compressed with GZip".CompressGZip(Encoding.UTF32).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 97, 96, 96, 200, 0, 226, 76, 32, 46, 6, 98, 5, 32, 46, 135, 242, 115, 160, 24, 36, 150, 4, 196, 169, 80, 118, 50, 16, 231, 3, 113, 46, 16, 23, 0, 113, 17, 84, 174, 24, 138, 65, 236, 20, 52, 179, 74, 160, 246, 128, 196, 220, 129, 56, 10, 42, 14, 210, 15, 0, 31, 48, 183, 62, 132, 0, 0, 0 }));
        }

        [TestMethod]
        public void CompressGZipWithUTF7EncodingTest()
        {
            Assert.IsTrue("This will be compressed with GZip".CompressGZip(Encoding.UTF7).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 201, 200, 44, 86, 40, 207, 204, 201, 81, 72, 74, 85, 72, 206, 207, 45, 40, 74, 45, 46, 78, 77, 1, 10, 149, 100, 40, 184, 71, 101, 22, 0, 0, 58, 161, 211, 97, 33, 0, 0, 0 }));
        }

        [TestMethod]
        public void CompressGZipWithUTF8EncodingTest()
        {
            Assert.IsTrue("This will be compressed with GZip".CompressGZip(Encoding.UTF8).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 201, 200, 44, 86, 40, 207, 204, 201, 81, 72, 74, 85, 72, 206, 207, 45, 40, 74, 45, 46, 78, 77, 1, 10, 149, 100, 40, 184, 71, 101, 22, 0, 0, 58, 161, 211, 97, 33, 0, 0, 0 }));
        }

        [TestMethod]
        public void ToArabicLessThan4000Test()
        {
            Assert.AreEqual("MCCXXXIV".ToArabic(), 1234);
        }

        [TestMethod]
        public void ToArabicMoreThan4000Test()
        {
            Assert.AreEqual("((IX)CMXCIX)CMXCIX".ToArabic(), 9999999);
        }

        [TestMethod]
        public void ToPascalCaseTest()
        {
            Assert.AreEqual("tHis iS PASCAL case".ToPascalCase(), "ThisIsPascalCase");
        }

        [TestMethod]
        public void ToPascalCaseWithOnlyOneLetterTest()
        {
            Assert.AreEqual("a".ToPascalCase(), "a");
        }

        [TestMethod]
        public void ToPascalCaseWithTwoLettersTest()
        {
            Assert.AreEqual("ab".ToPascalCase(), "Ab");
        }

        [TestMethod]
        public void ToLowerCamelCaseTest()
        {
            Assert.AreEqual("tHis iS LOwER caMEl case".ToPascalCase(), "ThisIsLowerCamelCase");
        }

        [TestMethod]
        public void ToLowerCamelCaseWithOnlyOneLetterTest()
        {
            Assert.AreEqual("a".ToLowerCamelCase(), "a");
        }

        [TestMethod]
        public void ToLowerCamelCaseWithTwoLettersTest()
        {
            Assert.AreEqual("Ab".ToLowerCamelCase(), "ab");
        }

        [TestMethod]
        public void ToProperCaseTest()
        {
            Assert.AreEqual("ThisWillBeProperCase".ToProperCase(), "This Will Be Proper Case");
        }

        [TestMethod]
        public void ToProperCaseWithOnlyOneLetterTest()
        {
            Assert.AreEqual("a".ToProperCase(), "a");
        }

    }
}
