namespace SolutonBankAccount.Classes
{
    public abstract class Account
    {
        #region Private fields

        private string _id;
        private decimal _ballance;

        #endregion

        protected Account(string id, decimal ballance)
        {
            _id = id;
            _ballance = ballance;
        }
    }
}
