using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary
{
    class SalaryException : Exception
    {
        public decimal Value { get; }
        public SalaryException(string message) : base(message)
        {
        }
        public SalaryException(string message, decimal value) : base(message)
        {
            Value = value;
        }
    }

    class PostException : Exception
    {
        public string Value { get; }
        public PostException(string message) : base(message)
        {
        }
        public PostException(string message, string value) : base(message)
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

    class TakeBookException : Exception 
    {
        public DateTime Value { get; }
        public TakeBookException(string message) : base(message)
        {
        }
        public TakeBookException(string message, DateTime value) : base(message)
        {
            Value = value;
        }
    }

    class ProdYearException : Exception
    {
        public int Value { get; }
        public ProdYearException(string message) : base(message)
        {
        }
        public ProdYearException(string message, int value) : base(message)
        {
            Value = value;
        }
    }
    class GenreException : Exception
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
}
