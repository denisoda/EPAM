using System;
using System.Data.Entity;
using DAL;
using MySql.Data.Entity;
using SolutonBankAccount.Classes;

namespace DataLL.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BankContex : DbContext
    {
        public BankContex() : base("name=BankAccounts")
        {

        }

        public DbSet<AccountModel> Accounts { get; set; } 
    }
}