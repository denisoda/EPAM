using System;
using System.Collections.Generic;
using System.ComponentModel;
using SolutonBankAccount.Classes.Abstract;
using SolutonBankAccount.Exeptions;
using SolutonBankAccount.Enum;

namespace SolutonBankAccount.Classes
{
    [Serializable]
    public class BankAccount : Account
    {
        public string FName { get; }
        public string SName { get; }
        public decimal BonusPoints { get; private set; }
        public readonly List<BankAccount> Accounts;
        public readonly AccountRate rate;

        #region Constructors

        public BankAccount(string id, decimal ballance, string fName, string sName, decimal bonusPoints, AccountRate rate) : base(id, ballance)
        {
            if (!System.Enum.IsDefined(typeof(AccountRate), rate))
                throw new InvalidEnumArgumentException(nameof(rate), (int) rate, typeof(AccountRate));
            FName = fName;
            SName = sName;
            BonusPoints = bonusPoints;
            this.rate = rate;
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
            
            Ballance += amount * (int)rate;
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

            account.BonusPoints = 10 * (int) rate;

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
