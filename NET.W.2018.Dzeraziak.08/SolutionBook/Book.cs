using System.Text.RegularExpressions;
using System.Xml;
using System;
using System.ComponentModel.DataAnnotations;

namespace SolutionBook
{
    public class Book
    {
        private string _isbn;
        private string _author;

        public string Isbn
        {
            set
            {
                if (Regex.IsMatch(value, @"(?=.{13}$)\d{1,5}([- ])\d{1,7}\1\d{1,6}\1(\d|X)$"))
                {
                    _isbn = value;
                }
                else
                {
                    throw new ValidationException("The input data is not an ISBN");
                }
            }
            get => _isbn;
        }

        public string Author
        {
            set
            {
                if (Regex.IsMatch(value, @"[А-ЯA-Z][а-яa-z]*\040[А-ЯA-Z]\w*"))
                {
                    _author = value;
                }
            }
            get => _author;
        }

        public Book(string isbn, string author)
        {
            Isbn = isbn;
            Author = author;
        }
    }
}