using System;
using System.Collections.Generic;
using System.Text;

namespace SolutonBankAccount.Exeptions
{
    public class AccountDoesnotExist : Exception
    {
        public AccountDoesnotExist(string message)
            : base(message)
        {
        }
    }
}
