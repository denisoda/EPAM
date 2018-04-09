namespace SolutionBook.Extensions
{
    using System;
    using System.Linq;
    using SolutionBook;
    
    /// <summary>
    /// An exensions methods for Book class
    /// </summary>
    public static class ExtensionsBookFormat
    {
        /// <summary>
        /// Formats the book's object
        /// </summary>
        /// <param name="book">Extension class</param>
        /// <param name="bookParams">An array of book's object for the output</param>
        /// <returns>String result</returns>
        public static string FormatBook(this Book book, params dynamic[] bookParams)
            => bookParams.Aggregate(string.Empty, (current, t) => (string) (current + (" " + t))).Remove(0, 1);
    }
}