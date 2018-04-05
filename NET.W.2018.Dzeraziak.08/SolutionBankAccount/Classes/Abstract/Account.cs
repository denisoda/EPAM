namespace SolutonBankAccount.Classes.Abstract
{
    public abstract class Account
    {
        #region Private fields

        protected string Id;
        protected decimal Ballance;

        #endregion

        protected Account(string id, decimal ballance)
        {
            Id = id;
            Ballance = ballance;
        }
    }
}
