using BinaryTools.Extensions.Core;
using System;
using System.Linq;
using System.Text;
using Xunit;

namespace BinaryTools.xUnitTests.Extensions.Core.System
{
    public class StringExtensionsTest
    {
        [Fact]
        public void FormatTest()
        {
            string test_string = "{test_value_1} test {test_value_2}";
            Assert.Equal("TestValue1 test TestValue2",
                test_string.Format(
                    test_value_1 => "TestValue1",
                    test_value_2 => "TestValue2"
                )
            );
        }

        [Fact]
        public void FromHexTest()
        {
            Assert.Equal(100, "0x64".FromHex());
        }

        [Fact]
        public void CompressGZipTest()
        {
            Assert.True("This will be compressed with GZip".CompressGZip().SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 201, 200, 44, 86, 40, 207, 204, 201, 81, 72, 74, 85, 72, 206, 207, 45, 40, 74, 45, 46, 78, 77, 1, 10, 149, 100, 40, 184, 71, 101, 22, 0, 0, 58, 161, 211, 97, 33, 0, 0, 0 }));
        }

        [Fact]
        public void CompressGZipWithASCIIEncodingTest()
        {
            Assert.True("This will be compressed with GZip".CompressGZip(Encoding.ASCII).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 201, 200, 44, 86, 40, 207, 204, 201, 81, 72, 74, 85, 72, 206, 207, 45, 40, 74, 45, 46, 78, 77, 1, 10, 149, 100, 40, 184, 71, 101, 22, 0, 0, 58, 161, 211, 97, 33, 0, 0, 0 }));
        }

        [Fact]
        public void CompressGZipWithBigEndianUnicodeEncodingTest()
        {
            Assert.True("This will be compressed with GZip".CompressGZip(Encoding.BigEndianUnicode).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 99, 8, 97, 200, 96, 200, 100, 40, 102, 80, 96, 40, 7, 210, 57, 64, 168, 192, 144, 196, 144, 10, 36, 147, 25, 242, 25, 114, 25, 10, 24, 138, 128, 188, 98, 32, 76, 101, 72, 129, 170, 42, 1, 234, 81, 96, 112, 103, 136, 2, 178, 11, 0, 182, 85, 117, 9, 66, 0, 0, 0 }));
        }

        [Fact]
        public void CompressGZipWithUnicodeEncodingTest()
        {
            Assert.True("This will be compressed with GZip".CompressGZip(Encoding.Unicode).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 97, 200, 96, 200, 100, 40, 102, 80, 96, 40, 7, 210, 57, 64, 168, 192, 144, 196, 144, 10, 36, 147, 25, 242, 25, 114, 25, 10, 24, 138, 128, 188, 98, 32, 76, 101, 72, 129, 170, 42, 1, 234, 81, 96, 112, 103, 136, 2, 178, 11, 24, 0, 56, 205, 9, 238, 66, 0, 0, 0 }));
        }

        [Fact]
        public void CompressGZipWithUTF32EncodingTest()
        {
            Assert.True("This will be compressed with GZip".CompressGZip(Encoding.UTF32).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 97, 96, 96, 200, 0, 226, 76, 32, 46, 6, 98, 5, 32, 46, 135, 242, 115, 160, 24, 36, 150, 4, 196, 169, 80, 118, 50, 16, 231, 3, 113, 46, 16, 23, 0, 113, 17, 84, 174, 24, 138, 65, 236, 20, 52, 179, 74, 160, 246, 128, 196, 220, 129, 56, 10, 42, 14, 210, 15, 0, 31, 48, 183, 62, 132, 0, 0, 0 }));
        }

        [Fact]
        public void CompressGZipWithUTF7EncodingTest()
        {
            Assert.True("This will be compressed with GZip".CompressGZip(Encoding.UTF7).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 201, 200, 44, 86, 40, 207, 204, 201, 81, 72, 74, 85, 72, 206, 207, 45, 40, 74, 45, 46, 78, 77, 1, 10, 149, 100, 40, 184, 71, 101, 22, 0, 0, 58, 161, 211, 97, 33, 0, 0, 0 }));
        }

        [Fact]
        public void CompressGZipWithUTF8EncodingTest()
        {
            Assert.True("This will be compressed with GZip".CompressGZip(Encoding.UTF8).SequenceEqual(new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0, 11, 201, 200, 44, 86, 40, 207, 204, 201, 81, 72, 74, 85, 72, 206, 207, 45, 40, 74, 45, 46, 78, 77, 1, 10, 149, 100, 40, 184, 71, 101, 22, 0, 0, 58, 161, 211, 97, 33, 0, 0, 0 }));
        }

        [Fact]
        public void ToArabicLessThan4000Test()
        {
            Assert.Equal(1234, "MCCXXXIV".ToArabic());
        }

        [Fact]
        public void ToArabicMoreThan4000Test()
        {
            Assert.Equal(9999999, "((IX)CMXCIX)CMXCIX".ToArabic());
        }

        [Fact]
        public void ToPascalCaseTest()
        {
            Assert.Equal("ThisIsPascalCase", "tHis iS PASCAL case".ToPascalCase());
        }

        [Fact]
        public void ToPascalCaseWithOnlyOneLetterTest()
        {
            Assert.Equal("a", "a".ToPascalCase());
        }

        [Fact]
        public void ToPascalCaseWithTwoLettersTest()
        {
            Assert.Equal("Ab", "ab".ToPascalCase());
        }

        [Fact]
        public void ToLowerCamelCaseTest()
        {
            Assert.Equal("ThisIsLowerCamelCase", "tHis iS LOwER caMEl case".ToPascalCase());
        }

        [Fact]
        public void ToLowerCamelCaseWithOnlyOneLetterTest()
        {
            Assert.Equal("a", "a".ToLowerCamelCase());
        }

        [Fact]
        public void ToLowerCamelCaseWithTwoLettersTest()
        {
            Assert.Equal("ab", "Ab".ToLowerCamelCase());
        }

        [Fact]
        public void ToProperCaseTest()
        {
            Assert.Equal("This Will Be Proper Case", "ThisWillBeProperCase".ToProperCase());
        }

        [Fact]
        public void ToProperCaseWithOnlyOneLetterTest()
        {
            Assert.Equal("a", "a".ToProperCase());
        }
    }
}
