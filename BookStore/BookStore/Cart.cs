using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    [Serializable]
    public class Cart
    {
        public List<Book> books { get; set; }

        public Cart()
        {
            books = new List<Book>();
        }
        public void Add(Book book)
        {
            if (book == null)
                return;
            books.Add(book);
        }
        public void Remove(Book book)
        {
            if (book == null)
                return;
            books.Remove(book);
        }
        public int GetSum()
        {
            int Sum = 0;
            for (int i = 0; i < books.Count; i++)
            {
                Sum += books[i].Price;
            }
            return Sum;
        }
        public int Count()
        {
            return books.Count;
        }
    }
}
