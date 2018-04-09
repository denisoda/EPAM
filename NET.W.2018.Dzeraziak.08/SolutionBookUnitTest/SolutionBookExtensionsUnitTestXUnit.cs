using NUnit.Framework;
using NUnit.Framework.Internal;

namespace SolutionBook.Extensions.UnitTest.NUnit
{
    public class Tests
    {
        [TestCase(new Book("9783161484100", "Ilya Dzeraziak", "C# in a nutshell", "Orelly", 2014, 900, 60), ExpectedResult = "")]
        [Test]
        public string FormatBook_FortmattingBooksObject_IsCorrectString(Book book, params Book[] books)
        {
            book.FormatBook();
        }
    }
}