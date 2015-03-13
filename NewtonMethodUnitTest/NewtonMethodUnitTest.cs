using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewtonMethodLogicLayer;

namespace UnitTestProject1
{
    [TestClass]
    public class NewtonMethodUnitTest
    {
        [TestMethod]
        public void NewtonMethodTestMethod1()
        {
            double number = 1024;
            int power = 5;
            double accurancy = 0;
            Assert.AreEqual(4, NewtonMethod.Radical(number, power, accurancy));
        }

        [TestMethod]
        public void NewtonMethodTestMethod3()
        {
            double number = 0;
            int power = 5;
            double accurancy = 0;
            Assert.AreEqual(0, NewtonMethod.Radical(number, power, accurancy));
        }

        [TestMethod]
        public void NewtonMethodTestMethod4()
        {
            double number = 10;
            int power = 4;
            double accurancy = 0;
            Assert.AreEqual(1.778, NewtonMethod.Radical(number, power, accurancy), 1E-3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExeptionNewtonMethodTestMethod()
        {
            double number = -16;
            int power = 2;
            double accurancy = 0;
            NewtonMethod.Radical(number, power, accurancy);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ExeptionNewtonMethodTestMethod2()
        {
            double number = -16;
            int power = 0;
            double accurancy = 0;
            NewtonMethod.Radical(number, power, accurancy);
        }
    }
}
