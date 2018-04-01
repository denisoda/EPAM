using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBook
{
    internal class PriceIsNegativeValueException : Exception
    {
        /// <inheritdoc />
        /// <summary>
        /// Throws an exeption in case of price less than zero
        /// </summary>
        /// <param name="message">Message for the exeption</param>
        public PriceIsNegativeValueException(string message)
            : base(message)
        {

        }
    }
}
