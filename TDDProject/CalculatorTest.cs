using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]

        public void Operation_Add()
        {
            //Arrange - Organizar
            Calculator obj = new Calculator();
            //Act - Agir
            int result = obj.Add(10, 10);
            //Assert - Afirmar
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void Operation_Substract()
        {
            Calculator obj = new Calculator();
            int result = obj.Substract(10, 10);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Operation_Multiply()
        {
            Calculator obj = new Calculator();
            int result = obj.Multiply(10, 10);
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        public void Operation_Divide()
        {
            Calculator obj = new Calculator();
            int result = obj.Divide(10, 10);
            Assert.AreEqual(1, result);
        }
    }
}
