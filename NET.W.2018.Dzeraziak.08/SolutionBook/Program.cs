using System;

namespace SolutionBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("9783161484100", "Ilya Dzeraziak", "C# in a nutshell", "Orelly", 2014, 900, 60);
            var bookOther = new Book("9783161484101", "Ilya Dzeraziak", "C# in a nutshell", "Orelly", 2014, 900, 60);

            var eq = book.Equals(bookOther);
        }
    }
}
