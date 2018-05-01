using System;
using DAL.Context;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BankContext())
            {
                var client = new Client()
                {
                    Ballance = 10.2;
                }

                context.Clients.Add(client);
                context.SaveChanges();
            }
        }
    }
}
