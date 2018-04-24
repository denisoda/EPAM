using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using Ninject;
using Moq;
using BLL.Interfaces;
using SolutonBankAccount.Classes;
using SolutonBankAccount.Classes.Abstract;
using SolutonBankAccount.Enum;

namespace BLL.UnitTest
{   
    [TestFixture]
    class Test
    {
        [Test]
        [TestCase]
        public void test(string id, decimal ballance, string fname, string sname)
        {
            Mock<IBankAccountService> mockBankService = new Mock<IBankAccountService>();

            mockBankService
                .Setup(m => m.AddAccount(It.IsAny<BankAccount>()));

            Account ba = new BankAccount(id, ballance, fname, sname, AccountRate.Base, mockBankService.Object);

            Assert.AreEqual(mockBankService.)
        }
    }
}
