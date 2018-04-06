using System;
using SolutonBankAccount.Classes;
using SolutonBankAccount.Interfaces;

namespace SolutonBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutonBankAccount.Classes.BankAccount account = new BankAccount("0", 100, "Ilya", "Dzeraziak", 0);
            
            var service = new BankAccountService();

            account.AddFunds(15);
            account.CreateAccount(new BankAccount("1", 150, "Some", "As", 15));
            account.Accounts[0].AddFunds(200);
            account.CloseAccount(account.Accounts[0]);

            service.SaveToBinary(account);
        }
    }

}
