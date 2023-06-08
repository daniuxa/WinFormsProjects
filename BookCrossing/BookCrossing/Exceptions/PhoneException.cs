using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Exceptions
{
    class PhoneException : Exception   //Виключення, які виникають через неправильно введений номер телефону
    {
        public string Value { get; }  //Значення, через яке виникла помилка
        public PhoneException(string message) : base(message)
        {
        }
        public PhoneException(string message, string value) : base(message)
        {
            Value = value;
        }
    }
}
