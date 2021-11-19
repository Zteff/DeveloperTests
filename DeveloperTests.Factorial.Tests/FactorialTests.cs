using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeveloperTests.Factorial.Tests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        [DataRow(1,1)]
        [DataRow(2,2)]
        [DataRow(3,6)]
        [DataRow(4,24)]
        [DataRow(10, 3628800)]
        public void ValidInput_CorrectValueReturned(int i, int result)
        {
            Assert.AreEqual(result, Factorial.CalcFactorial(i));
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        public void InvalidInput_ThrowsArgumentException(int i)
        {
            Assert.ThrowsException<ArgumentException>(() => Factorial.CalcFactorial(i));
        }
    }
}
