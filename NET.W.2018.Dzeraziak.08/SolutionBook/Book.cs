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
        private string _publisher;
        private DateTime _publishDate;
        private decimal _price;

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
                    throw new ArgumentException($"Is not valid name of{nameof(Author)}");
                }
            }
            get => _author;
        }

        public string NameOfBook {

            private set
            {
                if (Regex.IsMatch(value, @"^[\D ]*$"))
                {
                    _author = value;
                }
                else
                {
                    throw new ArgumentException($"Is not valid name of {nameof(NameOfBook)}");
                }
            }

            get => _author;
        }

        public string Publisher
        {
            set
            {
                if (Regex.IsMatch(value, @"^[A-ZА-Яa-zа-я ]*$"))
                {
                    _publisher = value;
                }
                else
                {
                    throw new ArgumentException($"Is not valid name of {nameof(Publisher)}");
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

        public decimal Price
        {
            private set
            {
                if (value < 0)
                {
                    throw new PriceIsNegativeValueException($"{nameof(Price)} can not be less than zero");
                }
                else
                {
                    _price = value;
                }
            }

            get => _price;
        }
       

        public Book(string isbn, string author, string name, string publisher, int publishYear, ushort pageNumber, decimal price)
        {
            Isbn = isbn;
            Author = author;
            NameOfBook = name;
            Publisher = publisher;
            PublishYear = publishYear;
            PageNumber = pageNumber;
            Price = price;
        }
    }
}