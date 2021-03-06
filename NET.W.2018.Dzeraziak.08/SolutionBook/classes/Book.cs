﻿#define Log
using NLog;

namespace SolutionBook
{
    using System.Text.RegularExpressions;
    using System.Xml;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using SolutionBook.Exceptions;
    using SolutionBook.Exeptions;

    /// <summary>
    /// Class represents a Book item
    /// </summary>
    [Serializable]
    public class Book : IComparer<Book>, IEquatable<Book>
    {
        #region Private fields

        private readonly ILogger _logger;
        private string _isbn;
        private string _author;
        private string _publisher;
        private DateTime _publishDate;
        private decimal _price;
        private string _title;

        #endregion

        #region Public properties

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
                    _logger.Error($"ValidationException from {nameof(Isbn)} property {nameof(Book)} class");
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
                    _logger.Error($"ArgumentException from {nameof(Author)} property {nameof(Book)} class");
                    throw new ArgumentException($"Is not valid name of{nameof(Author)}");
                }
            }
            get => _author;
        }

        public string Title {

            private set
            {
                if (Regex.IsMatch(value, @"^[\D ]*$"))
                {
                    _title = value;
                }
                else
                {
                    _logger.Error($"ArgumentException from {nameof(Title)} property {nameof(Book)} class");
                    throw new ArgumentException($"Is not valid name of {nameof(Title)}");
                }
            }

            get => _title;
        }

        public string Publisher
        {
            private set
            {
                if (Regex.IsMatch(value, @"^[A-ZА-Яa-zа-я ]*$"))
                {
                    _publisher = value;
                }
                else
                {
                    _logger.Error($"ArgumentException from {nameof(Publisher)} property {nameof(Book)} class");
                    throw new ArgumentException($"Is not valid name of {nameof(Publisher)}");
                }
            }

            get => _publisher;
        }

        public  int PublishYear
        {
            private set
            {
                if (value < DateTime.MinValue.Year)
                {
                    _logger.Error($"ArgumentException from {nameof(PublishYear)} property {nameof(Book)} class : {{nameof(PublishYear)}}\'s value above the maximum possible");
                    throw new ArgumentException($"{nameof(PublishYear)}'s value below the maximum possible");
                }

                if (value > DateTime.MaxValue.Year)
                {
                    _logger.Error($"ArgumentException from {nameof(PublishYear)} property {nameof(Book)} class : {{nameof(PublishYear)}}\'s value above the maximum possible");
                    throw new ArgumentException($"{nameof(PublishYear)}'s value above the maximum possible");
                }

                _publishDate = new DateTime(value, 1, 1);
            }

            get => _publishDate.Year;
        }

        public ushort PageNumber{ private set; get; }

        public decimal Price
        {
            private set
            {
                if (value < 0)
                {
                    _logger.Error($"{nameof(Price)} can not be less than zero");
                    throw new PriceIsNegativeValueException($"{nameof(Price)} can not be less than zero");
                }
                else
                {
                    _price = value;
                }
            }

            get => _price;
        }

        #endregion

        #region Constructors

        public Book(string isbn, string author, string title, string publisher, int publishYear, ushort pageNumber, decimal price, ILogger logger)
        {
            Isbn = isbn;
            Author = author;
            Title = title;
            Publisher = publisher;
            PublishYear = publishYear;
            PageNumber = pageNumber;
            Price = price;
            _logger = logger;

            _logger.Log(LogLevel.Info, "Book constructor has been invoked");
        }

        protected Book(Book book, ILogger logger)
        {
            _logger = logger;
            Isbn = book.Isbn;
            Author = book.Author;
            Title = book.Title;
            Publisher = book.Publisher;
            PublishYear = book.PublishYear;
            PageNumber = book.PageNumber;
            Price = book.Price;

            _logger.Log(LogLevel.Info, "Book copy constructor has been invoked");
        }

        #endregion

        #region Interface realization

        /// <summary>
        /// Compares the prices of the book's object
        /// </summary>
        /// <param name="x">First book's object</param>
        /// <param name="y">Second book's object</param>
        /// <returns>1 if the price of the first book is bigger that second one</returns>
        public int Compare(Book x, Book y)
        {
            if (x is null || y is null)
            {
                _logger.Fatal($"NullReferenceException from {nameof(Compare)} {nameof(Book)} class");
                throw new NullReferenceException();
            }

            return x.Price > y.Price ? 1 : 0;
        }

        /// <summary>
        /// Equaliate the objects
        /// </summary>
        /// <param name="other">Object for equality check</param>
        /// <returns>Bool varible which represents equlity of the objects</returns>
        public bool Equals(Book other)
        {
            if (other is null)
            {
                _logger.Fatal($"NullReferenceException from {nameof(Equals)} {nameof(Book)} class");
                throw new NullReferenceException();
            }

            return Title.Equals(other.Title) && Isbn.Equals(other.Isbn) && Author.Equals(other.Author) && PublishYear.Equals(other.PublishYear)
                && PageNumber.Equals(other.PageNumber) && Price.Equals(other.Price);
        }

        #endregion

        #region Overridings

        public override string ToString() =>
            $"{Title} was written by {Author} in {PublishYear}. Published by \"{Publisher}\". Price: {Price:C} ISBN - {Isbn}";

        public override int GetHashCode() => Author.Length ^ PublishYear + Title.Length;

        #endregion
    }
}