using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Entities
{
    [Serializable]
    public class Person  //Клас персони (Автор, Клієнт)
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }      //Ім'я
        public string Surname { get; set; }   //Прізвище
    }
}
