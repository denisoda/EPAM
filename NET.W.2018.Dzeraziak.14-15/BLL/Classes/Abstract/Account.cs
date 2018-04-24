using System;

namespace SolutonBankAccount.Classes.Abstract
{
    [Serializable]
    public abstract class Account
    {
        #region Private fields

        public readonly string Id;
        public decimal Ballance {protected set; get;}

        #endregion

        protected Account(string id, decimal ballance = 0)
        {
            Id = id;
            Ballance = ballance;
        }
    }
}
