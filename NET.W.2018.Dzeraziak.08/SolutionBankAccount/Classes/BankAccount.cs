using System;

namespace SolutonBankAccount.Classes
{
    public class BankAccount : Account
    {
        private string FName { get; set; }

        private string SName { get; set; }

        private decimal BonusBalls { get; set; }
        #region Constructors

        public BankAccount(string id, decimal ballance, string fName, string sName, decimal bonusBalls) : base(id, ballance)
        {
            FName = fName;
            SName = sName;
            BonusBalls = bonusBalls;
        }

        #endregion
    }
}
