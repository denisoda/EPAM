using System;
using SolutonBankAccount.Classes;
using SolutonBankAccount.Enum;

namespace SolutonBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutonBankAccount.Classes.BankAccount account = new BankAccount("0", 100, "Ilya", "Dzeraziak", 0, AccountRate.Base);
            
            var service = new BankAccountService();

            account.AddFunds(15);
            account.CreateAccount(new BankAccount("1", 150, "Some", "As", 15, AccountRate.Platinum));
            account.Accounts[0].AddFunds(20);
            account.CloseAccount(account.Accounts[0]);

            service.SaveToBinary(account);
        }
    }

}
