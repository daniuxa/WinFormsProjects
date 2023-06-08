using BookCrossing.Exceptions;
using BookCrossing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Entities
{
    [Serializable]
    public class Client : Person //Користувач сервісом
    {
        private string phoneNumber;  //Номер телефону
        public string PhoneNumber 
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value.Length == 10 && Int64.TryParse(value, out long result) == true)
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new PhoneException("Неправильний формат номеру телефона", value);
                }
            }
        }
        public Cart cart { get; set; }     //Кошик користувача
        public IAccount ClientAccount { get; set; }  //Дані про акаунт користувача
        public Client(string Name, string Surname, string PhoneNumber, IAccount account) : base(Name, Surname) //Викликаємо конструктор Person
        {
            this.PhoneNumber = PhoneNumber;
            ClientAccount = account;
            cart = new Cart();
        }
    }
}
