using BookCrossing.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Entities
{
    [Serializable] //Клас можна записати в бінарний файл
    public class Book
    {
        public string Name { get; set; }   //Назва книги
        public Person Author { get; set; } //Автор

        private int publicationYear;      //Рік публікації
        public int PublicationYear 
        {
            get
            {
                return publicationYear;
            }
            set
            {
                if (value <= DateTime.Now.Year && value >= 0)
                {
                    publicationYear = value;
                }
                else
                {
                   throw new PublicationYearException("Неправильно задан рік публікації", value);
                }
            }
        }

        public string Genre { get; set; }  //Жанр

        public Book(string Name, Person Author, int PublicationYear, string Genre)
        {
            this.Name = Name;
            this.Author = Author;
            this.PublicationYear = PublicationYear;
            this.Genre = Genre;
        }
    }
}
