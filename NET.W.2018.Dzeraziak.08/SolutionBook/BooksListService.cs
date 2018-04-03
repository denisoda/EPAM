using System;
using System.Collections.Generic;
using System.Text;
using SolutionBook.Exeptions;

namespace SolutionBook
{
    class BooksListService
    {
        #region Private Fields 

        private List<Book> books;

        #endregion

        public int NumberOfBooks => books.Count;

        #region Publiu Methods

        public void AddBook(Book book)
        {
            if(books.Contains(book))
                throw new BookIsAlredyInTheListExeption($"The book is alredy in the {nameof(books)} list"); 
            
            books.Add(book);
        }

        #endregion
    }
}