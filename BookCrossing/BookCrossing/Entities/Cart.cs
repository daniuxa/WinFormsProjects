using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Entities
{
    [Serializable]
    public class Cart //Кошик
    {
        public List<Book> GivenBooks { get; set; }  //Книги, які віддав користувач
        public List<Book> TakenBooks { get; set; }  //Книги, які взяв користувач 

        public Cart()
        {
            GivenBooks = new List<Book>();
            TakenBooks = new List<Book>();
        }
        public void AddGivenBook(Book book)
        {
            if (book == null)
                return;
            GivenBooks.Add(book);
        }
        public void RemoveGivenBook(Book book)
        {
            if (book == null)
                return;
            GivenBooks.Remove(book);
        }
        public int CountGivenBook()
        {
            return GivenBooks.Count;
        }
        public void AddTakenBook(Book book)
        {
            if (book == null)
                return;
            TakenBooks.Add(book);
        }
        public void RemoveTakenBook(Book book)
        {
            if (book == null)
                return;
            TakenBooks.Remove(book);
        }
        public int CountTakenBook()
        {
            return TakenBooks.Count;
        }
    }
}
