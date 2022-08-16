using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    [Serializable]
    public class Book : IBook, IComparable<Book>
    {
        private List<string> Genres = new List<string>() { "По замовченню", "Повість", "Технічна література", "Бізнес", "Біографії", "Детектив", "Драма", "Історичний роман", "Класика", "Мелодрама", "Науково-популярна", "Поезія", "Пригодницький роман", "Психологія", "Сучасна проза", "Трилер", "Фантастика", "Роман" };

        public string Name { get; set; }
        //public string Author { get; set; }
        public Person Author { get; set; }
        private int publicationYear;
        public int PublicationYear  //PublicationYear = 1900;
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
        private int price;
        public int Price 
        { 
            get 
            {
                return price;
            } 
            set 
            {
                if (value >= 0 && value <= 1000000)
                {
                    price = value;
                }
                else
                {
                    throw new PriceException("Неправильно задана ціна", value);
                }
            }
        }
        private string genre;
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                bool check = false;
                foreach (string el in Genres) //for
                {
                    if (el == value)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == true)
                {
                    genre = value;
                }
                else
                {
                    throw new GenreException("Неправильно задан жанр", value);
                }
            }
        }

        public Book(string Name, Person Author, int PublicationYear, int Price, string Genre)
        {
            this.Name = Name;
            this.Author = Author;
            this.PublicationYear = PublicationYear;
            this.Price = Price;
            this.Genre = Genre;
        }

        public int CompareTo(Book other)
        {
            return PublicationYear.CompareTo(other.PublicationYear);
            //return Name.CompareTo(other.Name);
        }
    }
}
