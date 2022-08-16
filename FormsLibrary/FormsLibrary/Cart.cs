using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary
{
    [Serializable]
    public class Cart
    {
        public EventHandler<AddedBookToCartEventArg> AddedBookToCart;
        //public List<Book> books { get; set; }
        public Dictionary<Book, DateTime> books;
        public Cart()
        {
            books = new Dictionary<Book, DateTime>();
        }
        public void Add(Book book)
        {
            if (book == null)
                return;
            AddedBookToCart?.Invoke(book, new AddedBookToCartEventArg(book, DateTime.Now));
            books.Add(book, DateTime.Now);
        }
        public void Remove(Book book)
        {
            if (book == null)
                return;
            books.Remove(book);
        }
        public int Count()
        {
            return books.Count;
        }
    }
}
