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
            StringAssert.Equals("5DE9", string.Format(new HexCustomFormatter(), "{0:HEX}", decNumber));
        }
        [TestMethod]
        public void CustomFormatterTestMethod2()
        {
            int decNumber = 0;
            StringAssert.Equals("0", string.Format(new HexCustomFormatter(), "{0:HEX}", decNumber));
        }
        [TestMethod]
        public void CustomFormatterTestMethod3()
        {
            int decNumber = 24041;
            StringAssert.Equals("24041", string.Format(new HexCustomFormatter(), "{0}", decNumber));
        }
        [TestMethod]
        public void CustomFormatterTestMethod4()
        {
            int decNumber = 24041;
            StringAssert.Equals("2,404100E+004", string.Format(new HexCustomFormatter(), "{0:E}", decNumber));
        }
        [TestMethod]
        public void CustomFormatterTestMethod5()
        {
            string decNumber = "Hello";
            StringAssert.Equals("Hello", string.Format(new HexCustomFormatter(), "{0}", decNumber));
        }
    }
}
