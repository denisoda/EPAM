using System;

namespace SolutonBankAccount.Exeptions
{
    class ValueLessThanZero : Exception
    {
        ValueLessThanZero(string message)
            : base(message)
        {

        }
    }
}
