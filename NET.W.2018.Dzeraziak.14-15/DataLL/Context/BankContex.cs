using System.Data.Entity;
using DAL;
using SolutonBankAccount.Classes;

namespace DataLL.Context
{
    public class BankContex : DbContext
    {
        public BankContex() : base("name=BankAccounts")
        {

        }

        public DbSet<AccountModel> Accounts { get; set; } 
    }
}