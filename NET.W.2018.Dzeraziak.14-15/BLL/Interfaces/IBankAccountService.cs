using SolutonBankAccount.Classes.Abstract;
using System.Collections;
using DAL.Intefaces;

namespace BLL.Interfaces
{
    public interface IBankAccountService
    {
        void AddAccount(Account account);
        void RemoveAccount(Account account);
        bool IsContainsAccount(Account account);
        void SaveData(IDataSaver dataSaver);
    }
}