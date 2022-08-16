using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShowroom
{
    class PriceException : Exception
    {
        public int Value { get; }
        public PriceException(string message, int Value) : base(message)
        {
            this.Value = Value;
        }
    }
    class ProductionYearException : Exception
    {
        public int Value { get; }
        /*public string Message { get; }*/
        public ProductionYearException(string message, int Value) : base(message)
        {
            this.Value = Value;
         /* Message = message;*/
        }
    }
    class BodyTypeException : Exception
    {
        public string Value { get; }
        public BodyTypeException(string message, string Value) : base(message)
        {
            this.Value = Value;
        }
    }
    class TypeMotoException : Exception
    {
        public string Value { get; }
        public TypeMotoException(string message, string Value) : base(message)
        {
            this.Value = Value;
        }
    }
    class PhoneNumberException : Exception
    {
        public string Value { get; }
        public PhoneNumberException(string message, string Value) : base(message)
        {
            this.Value = Value;
        }
    }
    class VisitDateException : Exception
    {
        public DateTime Value { get; }
        public VisitDateException(string message, DateTime Value) : base(message)
        {
            this.Value = Value;
        }
    }
    class FileException : Exception
    {
        public string FilePath { get; }
        public FileException(string msg, string value) : base(msg)
        {
            FilePath = value;
        }
    }
}
