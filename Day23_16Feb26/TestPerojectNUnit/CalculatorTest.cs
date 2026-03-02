using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Calculator_App;

namespace TestProjectNUnit.Test
{
    [TestFixture]
    internal class CalculatorTest
    {
        private Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_Two_Nums()
        {
            int a = 1, b = 2;
            int result = calc.add(a, b);
            Assert.That(result, Is.EqualTo(3));
        }
		public void Subtract_Two_Nums()
		{
			int a = 5, b = 2;
			int result = calc.subtract(a, b);
			Assert.That(result, Is.EqualTo(3));
		}
        public void Multiply_Two_Nums()
        {
            int a = 1, b = 3;
            int result = calc.multiply(a, b);
            Assert.That(result, Is.EqualTo(3));
        }
        public void Divide_Two_Nums()
        {
            int a = 4, b = 2;
            double result = calc.divide(a, b);
            Assert.That(result, Is.EqualTo(2));
        }
		}
}
