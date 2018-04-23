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
    class BankAccountService : IBankAccountService
    {
        
        private List<Account> accounts;

        #region Consturctor

        BankAccountService(IDataSaver saver)
        {
            accounts = new List<Account>();
        }

        #endregion

        public void SaveData(IDataSaver data)
        {
            data.Save(accounts);
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {

        }

        public bool IsContainsAccount(Account account)
        {
            if(account == null)
                throw new NullReferenceException();
            
            return accounts.Contains(account);
        }
    }
}
