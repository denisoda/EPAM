using System;
using DAL.Classes;
using DAL;
using SolutonBankAccount.Enum;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankRep = new BankRepository();

            bankRep.AddCustomer(new AccountModel()
            {
                AccoutId = 0,
                Ballance = 100,
                FName = "Ilya",
                SName = "Dzeraziak"
            });
        }
    }
}
