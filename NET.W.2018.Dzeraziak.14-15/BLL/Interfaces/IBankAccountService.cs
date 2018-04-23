using SolutonBankAccount.Classes.Abstract;
using System.Collections;

namespace BLL.Interfaces
{
    public interface IBankAccountService
    {
        void AddAccount(Account account);
        void RemoveAccount(Account account);
        bool IsContainsAccount(Account account);
    }
}