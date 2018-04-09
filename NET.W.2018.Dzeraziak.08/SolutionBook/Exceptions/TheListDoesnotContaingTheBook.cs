namespace SolutionBook.Exeptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TheListDoesnotContaingTheBookExeption : Exception
    {
        /// <inheritdoc />
        /// <summary>
        /// Throws the exeption if the list does not contain a book
        /// </summary>
        public TheListDoesnotContaingTheBookExeption()
        {
        }
    }
}
