using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary
{
    [Serializable]
    public class Book : IComparable, IBook
    {
        private List<string> Genres = new List<string>() { "По замовченню", "Технічна література", "Бізнес", "Біографії","Детектив","Драма","Історичний роман","Класика","Мелодрама","Науково-популярна","Поезія","Пригодницький роман","Психологія","Сучасна проза","Трилер","Фантастика", "Роман", "Повість" };
        public string _name { get; set; } 
        public string _author { get; set; }
        private int _productionYear;
        public int _ProductionYear
        {
            get
            {
                return _productionYear;
            }
            set
            {
                if (value <= DateTime.Now.Year && value >= 0)
                    _productionYear = value;
                else
                    throw new ProdYearException("Невірно заданий рік видавництва", value);
            }
        }
        private string _genre;
        public string _Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                WorkingWithFiles<List<string>> workingWithFiles = new WorkingWithFiles<List<string>>();
                HashSet<string> hashset = new HashSet<string>();
                List<string> genres = workingWithFiles.ReadingFromFile("Genre.bin");
                if (genres == null)
                    throw new GenreException("Неправильно введений жанр", value);
                foreach (var genre in genres)
                {
                    hashset.Add(genre);
                }
                
                if (hashset.Contains(value) == true)
                {
                    _genre = value;
                }
                else
                    throw new GenreException("Неправильно введений жанр", value);
            }
        }

        public Book(string name, string author, int ProductionYear, string genre)
        {
            _name = name;
            _author = author;
            _ProductionYear = ProductionYear;
            _Genre = genre;
        }

        public int CompareTo(object obj)
        {
            Book o = obj as Book;
            if (o != null)
            {
                return _ProductionYear.CompareTo(o._ProductionYear);
            }
            else
            {
                throw new Exception("Неможливо порівняти два об'єкта");
            }
        }
    }
}
