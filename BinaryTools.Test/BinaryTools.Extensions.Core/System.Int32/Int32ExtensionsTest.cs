﻿using BinaryTools.Extensions.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTools.Test.BinaryTools.Extensions.Core
{
    /// <summary>
    /// Summary description for Int32ExtensionsTest
    /// </summary>
    [TestClass]
    public class Int32ExtensionsTest
    {
        public Int32ExtensionsTest()
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
        public void ToHexTest()
        {
            Assert.AreEqual(100.ToHex(), "0x64");
        }

        [TestMethod]
        public void ToRomanLessThan4000Test()
        {
            Assert.AreEqual(1234.ToRoman(), "MCCXXXIV");
        }

        [TestMethod]
        public void ToRomanMoreThan4000Test()
        {
            Assert.AreEqual(9999999.ToRoman(), "((IX)CMXCIX)CMXCIX");
        }

    }
}
