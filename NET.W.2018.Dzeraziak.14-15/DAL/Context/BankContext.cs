using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class BankContext : DbContext
    {
        public DbSet<Client> Clients {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BanklDB;Trusted_Connection=True;");
        }
    }
}