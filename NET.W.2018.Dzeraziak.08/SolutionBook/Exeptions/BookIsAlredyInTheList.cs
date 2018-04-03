using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBook.Exeptions
{
    public class BookIsAlredyInTheList : Exception
    {
        /// <summary>
        /// Throws the exeption if the book is alredy in the list
        /// </summary>
        /// <param name="message"></param>
        public BookIsAlredyInTheList(string message)
            : base(message)
        {

        }
    }
}
