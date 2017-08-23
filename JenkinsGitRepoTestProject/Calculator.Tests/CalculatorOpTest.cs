using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;


namespace Calculator.Tests
{
    [TestClass]
  public class CalculatorOpTest
    {
        [TestMethod]
        public void TestingAdd()
        {
            //Arranging the test
            CalculatorOP sut = new CalculatorOP();
            //Act
            int result = sut.Add(5,4);
            //Assert 
            Assert.AreEqual(9,result);
        }
        [TestMethod]
        public void TestingMul()
        {
            //Arranging the test
            CalculatorOP sut = new CalculatorOP();
            //Act
            int result = sut.mul(5, 4);
            //Assert 
            Assert.AreEqual(20, result);
        }
    }
}
