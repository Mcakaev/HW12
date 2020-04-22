using System;
using NUnit.Framework;
using calculator1;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculationTest
    {
        [TestCase(1,3,4)]
        [TestCase(-2, -6, -8)]
        [TestCase(-2, 2, 0)]
        public void TestSumMethod(double number1, double number2, double expRes)
        {           
            double actRes = new Calculculation().Sum(number1,number2);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(5, 3, 2)]
        [TestCase(-11, -2, -9)]
        [TestCase(-11, -11, 0)]
        public void TestDiffMethod(double number1, double number2, double expRes)
        {
            double actRes = new Calculculation().Diff(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(5, 3, 15)]
        [TestCase(-11, -2, 22)]
        [TestCase(-11, 2, -22)]
        [TestCase(-11, 0, 0)]
        [TestCase(0, 222, 0)]
        public void TestMultiplyMethod(double number1, double number2, double expRes)
        {
            double actRes = new Calculculation().Multiply(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(6,2,3)]
        [TestCase(-3,1,-3)]
        [TestCase(-3, -1, 3)]
        [TestCase(3, -1, -3)]
        [TestCase(0, 1, 0)]        
        [TestCase(15, 4, 3.75)]
        [TestCase(2.8, 1.4, 2)]
        public void TestDivMethod(double number1, double number2, double expRes)
        {            
                double actRes = new Calculculation().Division(number1, number2);
                Assert.AreEqual(expRes, actRes);          
        }
        [TestCase(1, 0, "∞")]
        public void TestDivByZero(double number1, double number2, string expRes)
        {
            double actRes = new Calculculation().Division(number1, number2);
            Assert.AreEqual(expRes, actRes.ToString());
        }
    }
}
