using System;

namespace SolutonBankAccount.Exeptions
{
    class ValueLessThanZero : Exception
    {
        public ValueLessThanZero(string message)
            : base(message)
        {

        }
    }
}
