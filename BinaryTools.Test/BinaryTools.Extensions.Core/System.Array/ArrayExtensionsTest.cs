using System.Linq;
using BinaryTools.Extensions.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTools.Test.BinaryTools.Extensions.Core
{
    /// <summary>
    /// Summary description for ArrayExtensionsTest
    /// </summary>
    [TestClass]
    public class ArrayExtensionsTest
    {
        public ArrayExtensionsTest()
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

        /* TODO: Add tests for these methods:
         *   - Int32 BinarySearch(this Array array, Object value)
         *   - Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value)
         *   - Int32 BinarySearch(this Array array, Object value, IComparer comparer)
         *   - Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value, IComparer comparer)
         *   - void ConstrainedCopy(this Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length)
         *   - void Copy(this Array sourceArray, Array destinationArray, Int32 length)
         *   - void Copy(this Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length)
         *   - void Copy(this Array sourceArray, Array destinationArray, Int64 length)
         *   - void Copy(this Array sourceArray, Int64 sourceIndex, Array destinationArray, Int64 destinationIndex, Int64 length)
         *   - 
         */


        // TODO: BinarySearch

        [TestMethod]
        public void ClearTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            test.Clear(2, 2);
            Assert.IsTrue(test.SequenceEqual(new string[] { "This", "is", null, null, "array" }));
        }

        [TestMethod]
        public void ClearAllTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            test.ClearAll();
            Assert.IsTrue(test.SequenceEqual(new string[] { null, null, null, null, null }));
        }

        // ConstrainedCopy

        // Copy

        [TestMethod]
        public void IndexOfReturnsIndexIfObjectIsFoundTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.AreEqual(test.IndexOf("a"), 2);
        }

        [TestMethod]
        public void IndexOfReturnsMinusOneIfObjectIsNotFoundTest()
        {
            string[] test = new string[] { };
            Assert.AreEqual(test.IndexOf("a"), -1);
        }

        [TestMethod]
        public void IndexOfReturnsIndexIfObjectIsFoundAfterStartIndexTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.AreEqual(test.IndexOf("a", 2), 2);
        }

        [TestMethod]
        public void IndexOfReturnsMinusOneIfObjectIsNotFoundAfterStartIndexTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.AreEqual(test.IndexOf("a", 3), -1);
        }

        [TestMethod]
        public void IndexOfReturnsIndexIfObjectIsFoundBetweenStartIndexAndCountTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.AreEqual(test.IndexOf("a", 1, 2), 2);
        }

        [TestMethod]
        public void IndexOfReturnsMinusOneIfObjectIsNotFoundBetweenStartIndexAndCountTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.AreEqual(test.IndexOf("a", 1, 1), -1);
        }

        [TestMethod]
        public void LastIndexOfReturnsLastIndexIfObjectIsFoundTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array", "for", "a", "test" };
            Assert.AreEqual(test.LastIndexOf("a"), 6);
        }

        [TestMethod]
        public void LastIndexOfReturnsMinusOneIfObjectIsNotFoundTest()
        {
            string[] test = new string[] { };
            Assert.AreEqual(test.LastIndexOf("a"), -1);
        }

        [TestMethod]
        public void LastIndexOfReturnsLastIndexIfObjectIsFoundAfterStartIndexTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array", "for", "a", "test" };
            Assert.AreEqual(test.LastIndexOf("a", 4), 2);
        }

        // LastIndexOf
        // Reverse
        // Sort
        // WithinIndex

    }
}
