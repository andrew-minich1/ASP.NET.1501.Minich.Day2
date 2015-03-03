using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclidAlgorithmLogicLayer;
using System.Diagnostics;

namespace BinaryEuclidAlgorithmTest
{
    [TestClass]
    public class BinaryEuclidAlgorithmTest
    {
        [TestMethod]
        public void BinaryEuclidAlgorithmTestMethod1()
        {
            int first = 486037628;
            int second = 7;
            Stopwatch stopWatch = new Stopwatch();
            Assert.AreEqual(1, LCMAlgorithm.BinaryEuclidAlgorithm(first, second, stopWatch));
            Assert.AreNotEqual(0, stopWatch.Elapsed.TotalMilliseconds);
        }

        [TestMethod]
        public void BinaryEuclidAlgorithmTestMethod2()
        {
            int first = 486037628;
            int second = 7;
            Stopwatch stopWatch = new Stopwatch();
            Assert.AreEqual(1, LCMAlgorithm.BinaryEuclidAlgorithm(first, second));
            Assert.AreEqual(0, stopWatch.Elapsed.TotalMilliseconds);
        }

        [TestMethod]
        public void BinaryEuclidAlgorithmTestMethod3()
        {
            int first = 0;
            int second = 5;
            Assert.AreEqual(5, LCMAlgorithm.BinaryEuclidAlgorithm(first, second));
        }
        [TestMethod]
        public void BinaryEuclidAlgorithmTestMethod4()
        {
            int first = 0;
            int second = 0;
            Assert.AreEqual(0, LCMAlgorithm.BinaryEuclidAlgorithm(first, second));
        }
        [TestMethod]
        public void BinaryEuclidAlgorithmTestMethod5()
        {
            int first = 5;
            int second = 5;
            Assert.AreEqual(5, LCMAlgorithm.BinaryEuclidAlgorithm(first, second));
        }
        [TestMethod]
        public void BinaryEuclidAlgorithmTestMethod6()
        {
            int first = -4;
            int second = 8;
            Assert.AreEqual(4, LCMAlgorithm.BinaryEuclidAlgorithm(first, second));
        }
    }
}
