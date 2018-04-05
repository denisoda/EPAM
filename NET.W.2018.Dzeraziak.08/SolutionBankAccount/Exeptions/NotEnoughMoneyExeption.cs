using System;
using System.Collections.Generic;
using System.Text;

namespace SolutonBankAccount.Exeptions
{
    class NotEnoughMoneyExeption : Exception
    {
        public NotEnoughMoneyExeption(string message)
            : base(message)
        {
        }
    }
}
