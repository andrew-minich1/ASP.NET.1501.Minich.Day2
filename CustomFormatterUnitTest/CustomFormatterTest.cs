using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomFormatterLogicLayer;

namespace CustomFormatterUnitTest
{
    [TestClass]
    public class CustomFormatterTest
    {
        [TestMethod]
        public void CustomFormatterTestMethod1()
        {
            int decNumber = 24041;
            Assert.AreEqual("5DE9", string.Format(new HexCustomFormatter(), "{0:HEX}", decNumber));
        }
        [TestMethod]
        public void CustomFormatterTestMethod2()
        {
            int decNumber = 0;
            Assert.AreEqual("0", string.Format(new HexCustomFormatter(), "{0:HEX}", decNumber));
        }
        [TestMethod]
        public void CustomFormatterTestMethod3()
        {
            int decNumber = 24041;
            StringAssert.Equals("24040", string.Format(new HexCustomFormatter(), "{0}", decNumber));
        }
        [TestMethod]
        public void CustomFormatterTestMethod4()
        {
            int decNumber = 24041;
            Assert.AreEqual("2,404100E+004", string.Format(new HexCustomFormatter(), "{0:E}", decNumber));
        }
        [TestMethod]
        public void CustomFormatterTestMethod5()
        {
            string decNumber = "Hello";
            Assert.AreEqual("Hello", string.Format(new HexCustomFormatter(), "{0}", decNumber));
        }

        [TestMethod]
        public void CustomFormatterTestMethod6()
        {
            double decNumber = 2.1;
            Assert.AreEqual("HEX", string.Format(new HexCustomFormatter(), "{0:HEX}", decNumber));
        }

        [TestMethod]
        public void CustomFormatterTestMethod7()
        {
            double decNumber = 10;
            Assert.AreEqual("HEX", string.Format(new HexCustomFormatter(), "{0:HEX}", decNumber));
        }
    }
}
