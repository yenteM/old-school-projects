using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculator;

namespace MyCalculator.tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new Calculator();
            int som = sut.Add(10, 5);
            Assert.That(som, Is.EqualTo(15));
        }

        [Test]
        [TestCase(10,5,5)]
        [TestCase(20, 10, 10)]
        [TestCase(75, 50, 25)]
        public void ShouldSubstractTwoNumbers(int firstnum, int secondnum, int expectednum)
        {
            var sut = new Calculator();
            int verschil = sut.Substract(firstnum, secondnum);
            Assert.That(verschil, Is.EqualTo(expectednum));
        }
    }
}
