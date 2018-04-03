using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SolutionBook.Exeptions;

namespace SolutionBook
{
    class BooksListService
    {
        #region Private Fields 

        private readonly List<Book> _books;

        #endregion

        public BooksListService()
        {
            _books = new List<Book>();
        }

        public int NumberOfBooks => _books.Count;

        #region Public Methods

        public void AddBook(Book book)
        {
            if(_books.Contains(book))
                throw new BookIsAlredyInTheList($"The book is alredy in the {nameof(_books)} list"); 
            
            _books.Add(book);
        }

        public Book FinBookByTag(Book book)
        {
            if (book is null)
                throw new NullReferenceException();

            if (_books.Contains(book))
                return book;                
            else 
                throw new BookServiceTheListDoesnotContaingTheBookExeption(); 
            
        }

        #endregion
    }
}