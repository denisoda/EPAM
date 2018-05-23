using System;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Collections;
using BLL.Interfaces;
using SolutonBankAccount.Classes.Abstract;

namespace SolutonBankAccount.Classes.Services
{
    public class BankAccountService : IBankAccountService
    {
        
        private readonly List<Account> _accounts;

        #region Consturctor

        private BankAccountService()
        {
            _accounts = new List<Account>();
        }

        #endregion

        public void SaveData()
        {
            
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {

        }

        public Account GetFirstAccount()
        {
            return _accounts[0];
        }

        public bool IsContainsAccount(Account account)
        {
            if(account == null)
                throw new NullReferenceException();
            
            return _accounts.Contains(account);
        }
    }
}
