using System;
using System.Collections.Generic;
using System.Linq;
using SolutonBankAccount.Classes.Abstract;
using SolutonBankAccount.Exeptions;

namespace SolutonBankAccount.Classes
{
    [Serializable]
    public class BankAccount : Account
    {
        public string FName { get; }
        public string SName { get; }
        public decimal BonusBalls { get; }
        public readonly List<BankAccount> Accounts;

        #region Constructors

        public BankAccount(string id, decimal ballance, string fName, string sName, decimal bonusBalls) : base(id, ballance)
        {
            FName = fName;
            SName = sName;
            BonusBalls = bonusBalls;
            Accounts = new List<BankAccount>();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds the money to the accout
        /// </summary>
        /// <param name="amount">Amount of money to add</param>
        public void AddFunds(decimal amount)
        {
            if (amount < 0)
                throw new ValueLessThanZero($"{nameof(amount)} can not be less than zero");
            
            Ballance += amount;
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

            Accounts.Add(account);
        }

        public void CloseAccount(BankAccount account)
        {
            if (account == null)
                throw new ArgumentNullException();

            if(Accounts.Contains(account))
                Accounts.Remove(account);
            else
                throw new AccountDoesnotExist($"{account} the account does not exist");
        }

        #endregion
    }
}
