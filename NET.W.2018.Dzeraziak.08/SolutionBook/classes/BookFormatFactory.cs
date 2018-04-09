using System;
using SolutionBook;

namespace SolutionBook.classes
{
    public static class BookFormatFacttory
    {
        /// <summary>
        /// Formats the book's object
        /// </summary>
        /// <param name="book">Extension class</param>
        /// <param name="bookParams">An array of book's object for the output</param>
        /// <returns>String result</returns>
        public static string FormatBook(this Book book, params dynamic[] bookParams)
        {
            string result = "";

            for(int i=0;i<bookParams.Length; i++)
            {
                result += " " + bookParams[i];
            }

            return result;
        }

    }
}