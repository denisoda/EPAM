using System;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Collections;
using DAL.Intefaces;
using BLL.Interfaces;
using SolutonBankAccount.Classes.Abstract;

namespace SolutonBankAccount.Classes.Services
{
    public class BankAccountService : IBankAccountService
    {
        
        private readonly List<Account> _accounts;

        #region Consturctor

        private BankAccountService(IDataSaver saver)
        {
            _accounts = new List<Account>();
        }

        #endregion

        public void SaveData(IDataSaver data)
        {
            data.Save(_accounts);
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {

        }

        public bool IsContainsAccount(Account account)
        {
            if(account == null)
                throw new NullReferenceException();
            
            return _accounts.Contains(account);
        }
    }
}
