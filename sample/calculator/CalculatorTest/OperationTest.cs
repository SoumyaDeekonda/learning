using System;
using calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class OperationTest
    {
        [TestMethod]
        public void WantToTestAddFunctionality()
        {
            var operation = new Operation();
            int sum = operation.Add(2, 2);
            Assert.AreEqual(4,sum);
        }

        [TestMethod]
        public void WantToTestSubtractFunctionality()
        {
            var operation = new Operation();
            int sub = operation.Sub(4, 2);
            Assert.AreEqual(2,sub);
        }

        [TestMethod]
        public void WantToTestDivisonFunctionality()
        {
            var operation = new Operation();
            var div = operation.Div(4, 2);
            Assert.AreEqual(2, div);
        }

        [TestMethod]
        public void WantToTestDecimal()
        {
            var operation = new Operation();
            var div = operation.Div(3, 2);
            Assert.AreEqual(1.5, div);
        }

        [TestMethod]
        public void WantToTestMul()
        {
            var operation = new Operation();
            var mul = operation.Mul(3, 2);
            Assert.AreEqual(6, mul);
        }
    }
}
