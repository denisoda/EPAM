using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Ninject;
using Ninject.Modules;
using Ninject.Parameters;
using NLog;

namespace SolutionBook.Extensions.UnitTest.NUnit
{
    public class Tests
    {

        [TestCase("9783161484100", "Some Name", "C# in a nutshell", "Orelly", 2014, (ushort)900, 60, ExpectedResult = "Some Name Orelly")]
        [Test]
        public string FormatBook_FortmattingBooksObject_IsCorrectString(string isbn, string author, string title, string publisher, int year, ushort pages, decimal price)
        {
            using (IKernel kernel = new StandardKernel())
            {
                var book = kernel.Get<Book>(new ConstructorArgument("isbn",isbn), new ConstructorArgument("author", author), new ConstructorArgument("title", title),
                    new ConstructorArgument("publisher", publisher), new ConstructorArgument("year",(ushort)year), new ConstructorArgument("pages",pages), new ConstructorArgument("price", price));    

                Console.WriteLine(book.FormatBook(book.Author, book.Publisher));

                return book.FormatBook(book.Author, book.Publisher);
            }
           
        }
    }
}