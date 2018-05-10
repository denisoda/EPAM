using System;
<<<<<<< HEAD
using DAL.Classes;
using DAL;
using SolutonBankAccount.Enum;
=======
using DAL.Context;
>>>>>>> aed1e182c31918ddc36c1726305b42b1b6ef336e

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            var bankRep = new BankRepository();

            bankRep.AddCustomer(new AccountModel()
            {
                AccoutId = 0,
                Ballance = 100,
                FName = "Ilya",
                SName = "Dzeraziak"
            });
=======
            using(var context = new BankContext())
            {
                var client = new Client()
                {
                    Ballance = 10.2;
                }

                context.Clients.Add(client);
                context.SaveChanges();
            }
>>>>>>> aed1e182c31918ddc36c1726305b42b1b6ef336e
        }
    }
}
