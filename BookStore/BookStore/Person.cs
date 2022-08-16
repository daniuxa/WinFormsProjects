using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    [Serializable]
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
    }

}
