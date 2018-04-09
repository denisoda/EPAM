using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace SolutionBook.Extensions.UnitTest.NUnit
{
    public class Tests
    {
        [TestCase("9783161484100", "Ilya Dzeraziak", "C# in a nutshell", "Orelly", 2014, (ushort)900, 60,  ExpectedResult = "Ilya Dzeraziak Orelly")]
        [Test]
        public string FormatBook_FortmattingBooksObject_IsCorrectString(string isbn, string author, string title, string publisher, int year, ushort pages, decimal price)
        {
            var book = new Book(isbn, author, title, publisher, year, pages, price);

            Console.WriteLine(book.FormatBook(book.Author, book.Publisher));

            return book.FormatBook(book.Author, book.Publisher);
        }
    }
}