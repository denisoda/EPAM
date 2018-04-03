using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBook
{
    class BooksListService
    {
        #region Private Fields 

        private List<Book> books;

        #endregion

        public int NumberOfBooks => books.Count;

        #region Publiu Methods

        void AddBook(Book book)
        {
            if(books.Contains(book))
                throw new 
        }

        #endregion
    }
}