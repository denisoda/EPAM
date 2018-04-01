using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBook
{
    class BooksListService
    {
        #region Private Fields 

        private List<Book> _books;

        #endregion

        public int NumberOfBooks => _books.Count;
    }
}
