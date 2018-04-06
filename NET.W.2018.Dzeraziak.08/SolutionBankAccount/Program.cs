using System;
using SolutonBankAccount.Classes;

namespace SolutonBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutonBankAccount.Classes.BankAccount account = new BankAccount("0", 100, "Ilya", "Dzeraziak", 0);

            account.AddFunds(15);
        }
    }

}
