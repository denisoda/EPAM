using System.Collections;
using DAL.Interfaces;

namespace DAL.Classes
{
    public class BankRepository : IBankRepository
    {
        public IEnumerable GetAllAccouts()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetBallanceById(int id)
        {
            throw new System.NotImplementedException();
        }

        public string GetUserNameById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}