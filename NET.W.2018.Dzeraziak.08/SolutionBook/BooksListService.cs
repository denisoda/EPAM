using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SolutionBook.Exeptions;
using SolutionBook.Interfaces;

namespace SolutionBook
{
    class BooksListService : IFileSaver<Book>
    {
        #region Private Fields 

        private readonly List<Book> _books;

        private IDataFolderCreator dataFolder;

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

        /// <summary>
        /// Removes the given object from the list
        /// <exception cref="TheListDoesnotContaingTheBookExeption">Throws when the list does not contain the given object</exception>
        /// </summary>
        /// <param name="book">A book object</param>
        public void RemoveBook(Book book)
        {
            if (book is null)
                throw new ArgumentNullException($"The {nameof(book)} is null");

            if (_books.Contains(book))
                _books.Remove(book);
            else
            {
                throw new TheListDoesnotContaingTheBookExeption();
            }
        }

        public void SortByTag(IComparer<Book> comparer)
        {
            if(comparer == null)
                throw new ArgumentNullException();

            _books.Sort(comparer);
        }
        #endregion

        public void SaveToFile()
        {
            dataFolder = new Data();

            dataFolder.CreateDataFolder();

            using (BinaryWriter bw = new BinaryWriter(File.Open(Data.path, FileMode.Create)))
            {
                bw.Write(_books);
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}