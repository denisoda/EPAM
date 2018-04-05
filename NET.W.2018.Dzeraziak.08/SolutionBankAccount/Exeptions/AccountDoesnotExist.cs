using System;
using System.Collections.Generic;
using System.Text;

namespace SolutonBankAccount.Exeptions
{
    class AccountDoesnotExist : Exception
    {
        AccountDoesnotExist(string message)
            : base(message)
        {
        }
    }
}
