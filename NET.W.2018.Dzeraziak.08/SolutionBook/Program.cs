using System;
using System.IO;

namespace SolutionBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("9783161484100", "Ilya Dzeraziak", "C# in a nutshell", "Orelly", 2014, 900, 60);
            var bookOther = new Book("9783161484101", "Ilya Dzeraziak", "C# in a nutshell", "Orelly", 2014, 900, 60);
            var bookOther0 = new Book("9783161484101", "Ilya Dzeraziak", "C# in a nutshell", "Orelly", 2014, 900, 60);

            BooksListService bk = new BooksListService();;

            bk.AddBook(book);
            bk.AddBook(bookOther);
            bk.AddBook(bookOther0);

            var a = bk.FinBookByAuthor((book1 => book1.PublishYear == 2014));

            Console.WriteLine(book.ToString());

            var dir = Directory.GetCurrentDirectory();
        }
    }
}
