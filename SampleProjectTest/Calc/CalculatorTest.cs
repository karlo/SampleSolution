using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProject.Calc;

namespace SampleProjectTest.Calc
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
