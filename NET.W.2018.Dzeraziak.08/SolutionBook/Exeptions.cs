using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBook
{
    internal class PriceIsNegativeValueException : Exception
    {
        public PriceIsNegativeValueException(string message)
            : base(message)
        {

        }
    }
}
