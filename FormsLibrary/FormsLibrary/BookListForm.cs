using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLibrary
{
    delegate void ChangeStyle(ListViewItem item, Color color);
    public partial class BookListForm : Form
    {
        private WorkingWithFiles<List<Book>> FileListBook = new WorkingWithFiles<List<Book>>();
        public Cart cart = null;
        private Book book;
        private List<Book> books = null;
        List<Book> filtredBooks = new List<Book>();
        public BookListForm(Book book, Cart cart)
        {
            InitializeComponent();
            this.book = book;
            this.cart = cart;
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            List<Book> filtredBooks = null;
            books = FileListBook.ReadingFromFile("Books.bin");
            if (books == null)
            {
                MessageBox.Show("Помилка при читанні файлу");
                return;
            }
            /*BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Books.bin", FileMode.OpenOrCreate))
            {
                books = (List<Book>)formatter.Deserialize(fs);
            }*/
            filtredBooks = FiltringBooks();
            AddBookToListView(filtredBooks, delegate(ListViewItem item, Color color) { item.SubItems[0].BackColor = color; });
        }
        private List<Book> FiltringBooks()
        {
            
            bool CheckName = true;
            bool CheckAuthor = true;
            bool CheckProdYear = true;
            bool CheckGenre = true;
            foreach (var bookInList in books)
            {
                if (book._name != "")
                {
                    if (bookInList._name == book._name)
                    {
                        CheckName = true;
                    }
                    else
                    {
                        CheckName = false;
                    }
                }
                if (book._author != "")
                {
                    if (bookInList._author == book._author)
                    {
                        CheckAuthor = true;
                    }
                    else
                    {
                        CheckAuthor = false;
                    }
                }
                if (book._ProductionYear != 0)
                {
                    if (bookInList._ProductionYear == book._ProductionYear)
                    {
                        CheckProdYear = true;
                    }
                    else
                    {
                        CheckProdYear = false;
                    }
                }
                if (book._Genre != "По замовченню")
                {
                    if (bookInList._Genre == book._Genre)
                    {
                        CheckGenre = true;
                    }
                    else
                    {
                        CheckGenre = false;
                    }
                }
                if (CheckName == true && CheckAuthor == true && CheckProdYear == true && CheckGenre == true)
                {
                    filtredBooks.Add(bookInList);
                }
                CheckName = true;
                CheckAuthor = true;
                CheckProdYear = true;
                CheckGenre = true;
            }
            return filtredBooks;
        }
        private void AddBookToListView(List<Book> books, ChangeStyle changeStyleBookLines)
        {
            ListViewItem item = null;
            foreach (var book in books)
            {
                item = new ListViewItem(new string[] { book._name, book._author, book._ProductionYear.ToString(), book._Genre });
                changeStyleBookLines(item, Color.LightGray);               
                //changeStyleBookLines(item, Color.Black);
                BookListView.Items.Add(item);
            }
        }
        private void ChangeBackGroundColor(ListViewItem item, Color color)
        {
            item.SubItems[0].BackColor = color;
        }
        private void ChangeForeColor(ListViewItem item, Color color)
        {
            item.SubItems[0].ForeColor = color;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (BookListView.SelectedItems.Count != 0)
            {
                if (cart == null)
                    cart = new Cart();
                cart.AddedBookToCart += ShowMsg;
                for (int i = 0; i < BookListView.SelectedItems.Count; i++)
                {
                    cart.Add(filtredBooks[BookListView.SelectedItems[i].Index]);
                }
                cart.AddedBookToCart -= ShowMsg;
            }
            else
            {
                MessageBox.Show("Виберіть хоча б одну книгу");
            }
        }

        private void ChangeFiltreButton_Click(object sender, EventArgs e)
        {
            FilterForm form = new FilterForm(cart);
            form.ShowDialog();
        }

        private void ViewCartButton_Click(object sender, EventArgs e)
        {
            if (cart != null)
            {
                if (cart.Count() != 0)
                {
                    CartForm form = new CartForm(ref cart);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Корзина пуста");
                }
            }
            else
            {
                MessageBox.Show("Корзина пуста");
            }
        }
        private void ShowMsg(object sender, AddedBookToCartEventArg addedBookToCart)
        {
            Book book = sender as Book;
            if (book != null)
                MessageBox.Show($"У кошик додано книгу {book._name}\n\nЧас: {addedBookToCart.timeAdded.ToString("G")}");
        }
    }

    public class AddedBookToCartEventArg : EventArgs
    {
        public Book book { get; set; }
        public DateTime timeAdded { get; set; }

        public AddedBookToCartEventArg(Book book, DateTime timeAdded)
        {
            this.book = book;
            this.timeAdded = timeAdded;
        }
    }

}