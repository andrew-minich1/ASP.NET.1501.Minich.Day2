using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclidAlgorithmLogicLayer;
using System.Diagnostics;

namespace EuclidAlgorithmUnitTest
{
    [TestClass]
    public class EuclidAlgorithmTest
    {
        [TestMethod]
        public void EuclidAlgorithmTestMethod1()
        {
            int first = 486037628;
            int second = 7;
            Stopwatch stopWatch = new Stopwatch();
            Assert.AreEqual(1,LCMAlgorithm.EuclidAlgorithm(first, second, stopWatch));
            Assert.AreNotEqual(0, stopWatch.Elapsed.TotalMilliseconds);
        }

        [TestMethod]
        public void EuclidAlgorithmTestMethod2()
        {
            int first = 900000;
            int second = 7;
            Stopwatch stopWatch = new Stopwatch();
            Assert.AreEqual(1, LCMAlgorithm.EuclidAlgorithm(first, second));
            Assert.AreEqual(0, stopWatch.Elapsed.TotalMilliseconds);
        }

        [TestMethod]
        public void EuclidAlgorithmTestMethod3()
        {
            int first = 0;
            int second = 5;
            Stopwatch stopWatch = new Stopwatch();
            Assert.AreEqual(5,LCMAlgorithm.EuclidAlgorithm(first, second, stopWatch));
        }
        [TestMethod]
        public void EuclidAlgorithmTestMethod4()
        {
            int first = 0;
            int second = 0;
            Stopwatch stopWatch = new Stopwatch();
            Assert.AreEqual( 0,LCMAlgorithm.EuclidAlgorithm(first, second, stopWatch));
        }
        [TestMethod]
        public void EuclidAlgorithmTestMethod5()
        {
            int first = 5;
            int second = 5;
            Stopwatch stopWatch = new Stopwatch();
            Assert.AreEqual(5,LCMAlgorithm.EuclidAlgorithm(first, second, stopWatch));
        }
        [TestMethod]
        public void EuclidAlgorithmTestMethod6()
        {
            int first = -4;
            int second = 8;
            Stopwatch stopWatch = new Stopwatch();
            Assert.AreEqual(4,LCMAlgorithm.EuclidAlgorithm(first, second, stopWatch));
        }
    }
}
