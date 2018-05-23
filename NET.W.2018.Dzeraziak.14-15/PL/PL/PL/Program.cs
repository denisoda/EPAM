using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            var rep = new BankRepository();

            rep.AddCustomer(new AccountModel()
            {
                FName = "ILya",
                SName = "Dzeraziak",
                Ballance = 100,
            });

            var acc = rep.GetAllAccouts();

            foreach (var account in acc)
            {
                Console.WriteLine(account);
            }
        }
    }
}
