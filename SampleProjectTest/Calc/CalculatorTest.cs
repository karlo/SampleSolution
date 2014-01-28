using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleProject.Calc
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestSumSuccess()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(20,calc.Sum(10, 10));
        }
    }
}
