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
        [TestCase("10", 0, "Ilya", "Dzeraziak", 100)]
        public void CreateAccount_NewBankAccount_HasAddedsuccessfully(string id, decimal ballance, string fname, string sname, decimal bonusPoints)
        {
            Mock<IBankAccountService> mockBankService = new Mock<IBankAccountService>();
            
            int mockCallback = 0;
            
            mockBankService
                .Setup(m => m.AddAccount(It.IsAny<BankAccount>()))
                .Callback(() => mockCallback++);
            
            Assert.AreEqual(mockCallback, 1);
        }
    }
}
