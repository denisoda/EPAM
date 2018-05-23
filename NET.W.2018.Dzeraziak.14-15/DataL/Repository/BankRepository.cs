using System.Collections;
using DataLL.Context;
using DAL.Interfaces;
using System.Linq;
using System.Data.Entity;

namespace DAL
{
    public class BankRepository : IBankRepository
    {
        public IEnumerable GetAllAccouts()
        {
            using (var bank = new BankContex())
            {
                return bank.Accounts;
            }
        }

        public decimal GetBallanceById(int id)
        {
            throw new System.NotImplementedException();
        }

        public string GetUserNameById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddCustomer(AccountModel customer)
        {
            using (var bank = new BankContex())
            {
                bank.Accounts.Add(customer);
                bank.SaveChangesAsync();
            }
        }
    }
}