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
        private IDataSaver _saver;
        private List<Account> accounts;

        BankAccountService(IDataSaver saver)
        {
            _saver = saver;
            accounts = new List<Account>();
        }

        public void save(IEnumerable data)
        {
            _saver.Save(data);
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
