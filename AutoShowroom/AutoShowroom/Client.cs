using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShowroom
{
    /*Класс клиента, реализует интерфейсы IClient, IComparable*/
    [Serializable]
    public class Client : IClient, IComparable
    {
        public string Name { get; set; }        //Имя
        public string Surname { get; set; }     //Фамилия
        private string phoneNumber;             //Номер телефона
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                /*int TryParse(int value)
                 {
                    int result;
                       ...
                    return result;
                }
                 */
                if (value.Length == 10 && Int32.TryParse(value, out int result) == true)
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new PhoneNumberException("Неправильно введено номер телефону", value);
                }
            }
        }
        private DateTime visitDate;             //Дата визита автосалона
        public DateTime VisitDate
        {
            get
            {
                return visitDate;
            }
            set
            {
                if (value >= DateTime.Now && value.Year <= DateTime.Now.Year + 1)
                    visitDate = value;
                else
                {
                    throw new VisitDateException("Неправильно введена дата візиту", value);
                }
            }
        }
        public Vehicle ViewVehicle { get; set; } //Транспортное средство для просмотра
        
        public Client(string Name, string Surname, string PhoneNumber, DateTime VisitDate, Vehicle ViewVehicle)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.PhoneNumber = PhoneNumber;
            this.ViewVehicle = ViewVehicle;
            this.VisitDate = VisitDate;
        }

        //Метод интерфейса IComparable, который сравнивает обьекты по дата посещения
        public int CompareTo(object obj)
        {
            Client p = obj as Client;
            if (p != null)
                return VisitDate.CompareTo(p.VisitDate);
            else
                throw new Exception("Неможливо порівняти об'єкти");
        }
    }
}
