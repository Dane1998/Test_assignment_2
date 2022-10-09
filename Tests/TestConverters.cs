using Assignment2_test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;

namespace Tests

{
    [TestClass]
    public class TestConverters
    {

        [TestMethod]
        public void TestUppcase()
        {

            Assert.AreEqual("ABCD", Converters.Uppercase("abcd"));

        }
        public void TestLowercase()
        {

            Assert.AreEqual("abcd", Converters.Lowercase("ABCD"));

        }
        public void TestReverse()
        {

            Assert.AreEqual("abcd", Converters.Reverse("dcba"));

        }
    }
}