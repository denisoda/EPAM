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

        /// <summary>
        /// Finds the book by the given criteria
        /// </summary>
        /// <param name="tag">The predicate delegate</param>
        /// <returns>A book found by the given criteria</returns>
        public Book FinBookByAuthor(Predicate <Book> tag)
        {
            if (tag is null)
                throw new ArgumentNullException();

            return _books.Find(tag);
        }

        #endregion
    }
}