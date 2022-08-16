using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary
{
    [Serializable]
    public class Client : Person
    {
        private string _phone;
        public string _Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value.Length == 10)
                    _phone = value;
                else
                    throw new PhoneException("Неправильний формат номера", value);
            }
        }

        public Cart cart { get; set; }

        public Client (string name, string surname, string Phone, Cart cart) : base(name, surname)
        {
            _Phone = Phone;
            this.cart = cart;
        }

    }
}
