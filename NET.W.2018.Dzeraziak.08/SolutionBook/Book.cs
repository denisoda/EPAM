using System.Text.RegularExpressions;
using System.Xml;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SolutionBook
{
    public class Book
    {
        private string _isbn;
        private string _author;
        private DateTime _publishDate;

        public string Isbn
        {
            private set
            {
                if (Regex.IsMatch(value, @"^(?:ISBN(?:-13)?:? )?(?=[0-9]{13}$|(?=(?:[0-9]+[- ]){4})[- 0-9]{17}$)97[89][- ]?[0-9]{1,5}[- ]?[0-9]+[- ]?[0-9]+[- ]?[0-9]$"))
                {
                    _isbn = value;
                }
                else
                {
                    throw new ValidationException($"Is not valid {nameof(Isbn)}");
                }
            }
            get => _isbn;
        }

        public string Author
        {
            private set
            {
                if (Regex.IsMatch(value, @"[А-ЯA-Z][а-яa-z]*\040[А-ЯA-Z]\w*"))
                {
                    _author = value;
                }
                else
                {
                    throw new ValidationException($"Is not valid {nameof(Author)}");
                }
            }
            get => _author;
        }

        public string Name {

            private set
            {
                if (Regex.IsMatch(value, @"[A-ZА-Я]"))
                {
                    throw new ValidationException($"Is not valid {nameof(Name)}");
                }
                else
                {
                    _author = value;
                }
            }

            get => _author;
        }

        public string Publisher
        {
            set
            {
                if (Regex.IsMatch(value, @"[A-ZА-Я"))
                {
                    throw new ValidationException($"Is not valid {nameof(Publisher)}");
                }
            }

            get => _publisher;
        }

        public int PublishYear
        {
            private set => _publishDate = new DateTime(value, 0, 0);

            get => _publishDate.Year;
        }

        public ushort PageNumber{private set; get; }

        public ref readonly decimal Price
        {
            set
            {
                if (value < 0)
                {
                    throw new value
                }
            }
        }
       

        public Book(string isbn, string author, string name, string publisher, int publishYear, ushort pageNumber, decimal price)
        {
            Isbn = isbn;
            Author = author;
            Name = name;
            Publisher = publisher;
            PublishYear = publishYear;
            PageNumber = pageNumber;
            Price = price;
        }
    }
}