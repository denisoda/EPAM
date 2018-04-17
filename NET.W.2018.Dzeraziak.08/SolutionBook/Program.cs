using System;
using System.IO;
using SolutionBook.Exeptions;
using System.Collections;
using NLog;
using NLog.Common;
using NLog.Config;

namespace SolutionBook
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.Configuration = new XmlLoggingConfiguration($"Log{Path.DirectorySeparatorChar}Config{Path.DirectorySeparatorChar}NLog.config");
            var logger = NLog.LogManager.GetCurrentClassLogger();

            var book = new Book("9783161484100", "Ilya Dzeraziak", "C# in a nutshell", "Orelly", 2014, 900, 60, logger);
            var bookOther = new Book("9783161484101", "Ilya Dzeraziak", "C# in a nutshell", "Orelly", 2014, 900, 60, logger);

            BooksListService bk = new BooksListService();;

            bk.AddBook(book);
            bk.AddBook(bookOther);

            var a = bk.FinBookByAuthor((book1 => book1.PublishYear == 2014));


            Console.WriteLine(book.ToString());
        }
    }
}
