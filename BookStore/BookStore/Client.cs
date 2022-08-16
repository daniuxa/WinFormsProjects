using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    [Serializable]
    public class Client : IPerson, IComparable<Client>
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private string phoneNumber;
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
        private string email;
        public string Email { 
            get
            {
                return email;
            }
            set
            {
                if (value.Contains("@") == true && value.Contains(".") == true)
                {
                    email = value;
                }
                else
                {
                    throw new EmailException("Неправильно введена пошта", value);
                }
            }
        }
        /*public List<Book> BoughtBooks { get; set; }*/
        public Cart cart { get; set; }
        public Client(string Name, string Surname, string PhoneNumber, string Email, Cart cart)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.cart = cart;
        }
        public int CompareTo(Client other)
        {
            return cart.Count().CompareTo(other.cart.Count());
        }
    }
}
