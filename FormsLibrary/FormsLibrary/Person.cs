using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary
{
    [Serializable]
    public class Person : IPerson
    {
        public string _name { get; set; }
        public string _surname { get; set; }
        
        public Person (string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
          
    }
}
