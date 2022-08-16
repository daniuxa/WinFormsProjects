using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    interface IBook
    {
        string Name { get; set; }
        Person Author { get; set; }
        int PublicationYear { get; set; }
        int Price { get; set; }
        string Genre { get; set; }
    }
    interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }
    }
}
