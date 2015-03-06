using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclidAlgorithmLogicLayer;
using System.Diagnostics;

namespace EuclidAlgorithmUnitTest
{
    [TestClass]
    public class EuclidAlgorithmTest
    {
        #region EuclidAlgorithmTest
        [TestMethod]
        public void EuclidAlgorithmTestMethod1()
        {
            int first = 486037628;
            int second = 7;
            long watch;
            Assert.AreEqual(1, LCMAlgorithm.EuclidAlgorithm(first, second, out watch));
            Debug.WriteLine("watch = {0}", watch);
        }

        [TestMethod]
        public void EuclidAlgorithmTestMethod2()
        {
            int first = 900000;
            int second = 7;
            long watch;
            Assert.AreEqual(1, LCMAlgorithm.EuclidAlgorithm(first, second, out watch));
            Debug.WriteLine("watch = {0}", watch);

        }

        [TestMethod]
        public void EuclidAlgorithmTestMethod3()
        {
            int first = 0;
            int second = 5;
            Assert.AreEqual(5, LCMAlgorithm.EuclidAlgorithm(first, second));
        }
        [TestMethod]
        public void EuclidAlgorithmTestMethod4()
        {
            int first = 0;
            int second = 0;
            Assert.AreEqual(0, LCMAlgorithm.EuclidAlgorithm(first, second));
        }
        [TestMethod]
        public void EuclidAlgorithmTestMethod5()
        {
            int first = 5;
            int second = 5;
            long watch;
            Assert.AreEqual(5, LCMAlgorithm.EuclidAlgorithm(first, second, out watch));
            Debug.WriteLine("watch = {0}", watch);
        }
        [TestMethod]
        public void EuclidAlgorithmTestMethod6()
        {
            int first = -4;
            int second = 8;
            long watch;
            Assert.AreEqual(4, LCMAlgorithm.EuclidAlgorithm(first, second, out watch));
            Debug.WriteLine("watch = {0}", watch);
        } 
        #endregion

        #region BinaryEuclidAlgorithmTest
        [TestMethod]
        public void BinaryEuclidAlgorithmTestMethod1()
        {
            int first = 486037628;
            int second = 7;
            long time;
            Assert.AreEqual(1, LCMAlgorithm.BinaryEuclidAlgorithm(first, second, out time));
        }

        [TestMethod]
        public void BinaryEuclidAlgorithmTestMethod2()
        {
            int first = 486037628;
            int second = 7;
            long time;
            Assert.AreEqual(1, LCMAlgorithm.BinaryEuclidAlgorithm(first, second, out time));
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
        #endregion
    }
}
