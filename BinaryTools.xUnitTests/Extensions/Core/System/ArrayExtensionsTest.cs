using System;
using System.Linq;
using BinaryTools.Extensions.Core;
using Xunit;

namespace BinaryTools.xUnitTests.Extensions.Core.System
{
    public class ArrayExtensionsTest
    {
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

        [Fact]
        public void ClearTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            test.Clear(2, 2);
            Assert.True(test.SequenceEqual(new string[] { "This", "is", null, null, "array" }));
        }

        [Fact]
        public void ClearAllTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            test.ClearAll();
            Assert.True(test.SequenceEqual(new string[] { null, null, null, null, null }));
        }

        // ConstrainedCopy

        // Copy

        [Fact]
        public void IndexOfReturnsIndexIfObjectIsFoundTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.Equal(2, test.IndexOf("a"));
        }

        [Fact]
        public void IndexOfReturnsMinusOneIfObjectIsNotFoundTest()
        {
            string[] test = new string[] { };
            Assert.Equal(-1, test.IndexOf("a"));
        }

        [Fact]
        public void IndexOfReturnsIndexIfObjectIsFoundAfterStartIndexTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.Equal(2, test.IndexOf("a", 2));
        }

        [Fact]
        public void IndexOfReturnsMinusOneIfObjectIsNotFoundAfterStartIndexTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.Equal(-1, test.IndexOf("a", 3));
        }

        [Fact]
        public void IndexOfReturnsIndexIfObjectIsFoundBetweenStartIndexAndCountTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.Equal(2, test.IndexOf("a", 1, 2));
        }

        [Fact]
        public void IndexOfReturnsMinusOneIfObjectIsNotFoundBetweenStartIndexAndCountTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array" };
            Assert.Equal(-1, test.IndexOf("a", 1, 1));
        }

        [Fact]
        public void LastIndexOfReturnsLastIndexIfObjectIsFoundTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array", "for", "a", "test" };
            Assert.Equal(6, test.LastIndexOf("a"));
        }

        [Fact]
        public void LastIndexOfReturnsMinusOneIfObjectIsNotFoundTest()
        {
            string[] test = new string[] { };
            Assert.Equal(-1, test.LastIndexOf("a"));
        }

        [Fact]
        public void LastIndexOfReturnsLastIndexIfObjectIsFoundAfterStartIndexTest()
        {
            string[] test = new string[] { "This", "is", "a", "test", "array", "for", "a", "test" };
            Assert.Equal(2, test.LastIndexOf("a", 4));
        }

        // LastIndexOf
        // Reverse
        // Sort
        // WithinIndex

    }
}
