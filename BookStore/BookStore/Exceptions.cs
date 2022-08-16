using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class GenreException : Exception//string Message;
    {
        public string Value { get; }
        public GenreException(string message) : base(message)
        {
        }
        public GenreException(string message, string value) : base(message)
        {
            Value = value;
        }
    }

    class PriceException : Exception
    {
        public int Value { get; }
        public PriceException(string message) : base(message)
        {
        }
        public PriceException(string message, int value) : base(message)
        {
            Value = value;
        }
    }
    class PublicationYearException : Exception
    {
        public int Value { get; }
        public PublicationYearException(string message) : base(message)
        {
        }
        public PublicationYearException(string message, int value) : base(message)
        {
            Value = value;
        }
    }
    class PhoneException : Exception
    {
        public string Value { get; }
        public PhoneException(string message) : base(message)
        {
        }
        public PhoneException(string message, string value) : base(message)
        {
            Value = value;
        }
    }
    class EmailException : Exception
    {
        public string Value { get; }
        public EmailException(string message) : base(message)
        {
        }
        public EmailException(string message, string value) : base(message)
        {
            Value = value;
        }
    }
}
