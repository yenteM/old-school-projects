using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.tests
{
    [TestFixture]
    public class CheckingAccountTests
    {
        [Test]
        public void ShouldBeZero()
        {
            var sut = new CheckingAccount("yente", 1);
            Assert.That(sut.Balance, Is.EqualTo(0));
        }

        [Test]
        public void ShouldNotBeZero()
        {
            var sut = new CheckingAccount("yente", 1, 10);
            Assert.That(sut.Balance, Is.Not.EqualTo(0.0));
        }

        [Test]
        public void ShouldWithdraw()
        {
            var sut = new CheckingAccount("yente", 1, 10);
            sut.Withdraw(5);
            Assert.That(sut.Balance, Is.EqualTo(5));
        }



    }
}
