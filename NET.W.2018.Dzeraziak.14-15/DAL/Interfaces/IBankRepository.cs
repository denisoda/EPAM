using System.Collections;

namespace DAL.Interfaces
{
    public interface IBankRepository
    {
        IEnumerable GetAllAccouts();

        decimal GetBallanceById(int id);

        string GetUserNameById(int id);
    }
}