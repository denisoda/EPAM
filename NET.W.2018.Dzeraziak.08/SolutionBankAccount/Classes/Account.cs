namespace SolutonBankAccount.Classes
{
    public abstract class Account
    {
        private string _id;
        private decimal _ballance;

        protected Account(string id, decimal ballance)
        {
            _id = id;
            _ballance = ballance;
        }
    }
}
