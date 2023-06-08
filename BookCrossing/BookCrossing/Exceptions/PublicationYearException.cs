using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Exceptions
{
    public class PublicationYearException : Exception  //Виключення, які виникають через неправильно введений рік публікації
    {
        public int Value { get; }  //Значення, через яке виникла помилка
        public PublicationYearException(string message) : base(message)
        {
        }
        public PublicationYearException(string message, int value) : base(message)
        {
            Value = value;
        }
    }
}
