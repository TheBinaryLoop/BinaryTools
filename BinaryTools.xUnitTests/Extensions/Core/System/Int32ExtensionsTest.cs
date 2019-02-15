using BinaryTools.Extensions.Core;
using Xunit;

namespace BinaryTools.xUnitTests.Extensions.Core.System
{
    public class Int32ExtensionsTest
    {
        [Fact]
        public void ToHexTest()
        {
            Assert.Equal("0x64", 100.ToHex());
        }

        [Fact]
        public void ToRomanLessThan4000Test()
        {
            Assert.Equal("MCCXXXIV", 1234.ToRoman());
        }

        [Fact]
        public void ToRomanMoreThan4000Test()
        {
            Assert.Equal("((IX)CMXCIX)CMXCIX", 9999999.ToRoman());
        }
    }
}
