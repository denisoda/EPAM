using System;
using System.Collections.Generic;
using SolutonBankAccount.Classes.Abstract;
using SolutonBankAccount.Exeptions;

namespace SolutonBankAccount.Classes
{
    public class BankAccount : Account
    {
        public string FName { get; }
        public string SName { get; }
        public decimal BonusBalls { get; }
        private readonly List<BankAccount> _accounts;

        #region Constructors

        public BankAccount(string id, decimal ballance, string fName, string sName, decimal bonusBalls) : base(id, ballance)
        {
            FName = fName;
            SName = sName;
            BonusBalls = bonusBalls;
            _accounts = new List<BankAccount>();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds the money to the accout
        /// </summary>
        /// <param name="amount">Amount of money to add</param>
        public void AddFunds(decimal amount)
        {
            if(amount > Ballance)
                throw new NotEnoughMoneyExeption($"Was threw after the {nameof(AddFunds)} method, because the user does not have enought money on it's account");
            
        }

        /// <summary>
        /// Withdraws money from the account
        /// </summary>
        /// <param name="amount">Amount of money to withdraw</param>
        public void WithdrawMoney(decimal amount)
        {
            if (amount > Ballance)
                throw new NotEnoughMoneyExeption($"Was threw after the {nameof(WithdrawMoney)} method, because the user does not have enought money on it's account");
        }


        public void CreateAccount(BankAccount account)
        {
            if (account == null)
                throw new ArgumentNullException();

            _accounts.Add(account);
        }

        public void CloseAccount(BankAccount account)
        {
            if (account == null)
                throw new ArgumentNullException();

            if(!_accounts.Contains(account))
                _accounts.Remove(account);
            else
                throw new AccountDoesnotExist($"{account} the account does not exist");
        }

        #endregion
    }
}
