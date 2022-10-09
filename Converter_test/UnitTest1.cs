using Assignment2_test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;

namespace Converter_test

{
    [TestClass]
    public class UnitTest1
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