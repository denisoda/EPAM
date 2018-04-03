using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBook.Exeptions
{
    class BookServiceTheListDoesnotContaingTheBookExeption : Exception
    {
        /// <summary>
        /// Throws the exeption if the list does not contain a book
        /// </summary>
        /// <param name="message">Additional message</param>
        public BookServiceTheListDoesnotContaingTheBookExeption(string message)
            : base(message)
        {
        }
    }
}
