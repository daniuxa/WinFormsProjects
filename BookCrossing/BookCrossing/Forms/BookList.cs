using BookCrossing.Entities;
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

namespace BookCrossing.Forms
{
    public partial class BookList : Form
    { 
        private List<Book> booksFiltred = new List<Book>();  //Відфільтровані книги
        private List<Book> Books;        //всі книги, які є на сервісі
        private Book Book;               //Книга для фільтрації
        private List<Book> WantedBooks; //Книги, які клієнт хоче взяти
        private int quantityOfAvaibleBooks = 0;//Кількість книг доступних, щоб взяти
        private Client client;      //Потичний клієнт
        public BookList()
        {
            InitializeComponent();
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Books.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Books = (List<Book>)formatter.Deserialize(fs);
            }
        }
        public BookList(List<Book> WantedBooks, Book book, int quantity, Client client)
        {
            InitializeComponent();
            this.client = client;
            quantityOfAvaibleBooks = quantity;
            this.WantedBooks = WantedBooks;
            this.Book = book;
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Books.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Books = (List<Book>)formatter.Deserialize(fs);
            }
        }

        private void ChangeFiltersButton_Click(object sender, EventArgs e)
        {
            FilterForm form = new FilterForm(WantedBooks, client, quantityOfAvaibleBooks);
            form.ShowDialog();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            bool checkName = true;
            bool checkAuthor = true;
            bool checkGenre = true;
            bool checkPublicationYear = true;
            AvaibleQuantityLabel.Text += quantityOfAvaibleBooks;
            foreach (var book in Books)
            {
                if (Book.Name != "")
                {
                    if (Book.Name == book.Name)
                    {
                        checkName = true;
                    }
                    else
                    {
                        checkName = false;
                    }
                }
                if (Book.Author != null)
                {
                    if (Book.Author.Name == book.Author.Name && Book.Author.Surname == book.Author.Surname)
                    {
                        checkAuthor = true;
                    }
                    else
                    {
                        checkAuthor = false;
                    }
                }
                if (Book.Genre != "По замовченню")
                {
                    if (Book.Genre == book.Genre)
                    {
                        checkGenre = true;
                    }
                    else
                    {
                        checkGenre = false;
                    }
                }
                if (Book.PublicationYear != 0)
                {
                    if (Book.PublicationYear == book.PublicationYear)
                    {
                        checkPublicationYear = true;
                    }
                    else
                    {
                        checkPublicationYear = false;
                    }
                }
                if (checkName == true && checkAuthor == true && checkGenre == true && checkPublicationYear == true)
                {
                    
                    booksFiltred.Add(book);
                    checkName = true;
                    checkAuthor = true;
                    checkGenre = true;
                    checkPublicationYear = true;
                }
            }
            if (booksFiltred.Count == 0)
            {
                MessageBox.Show("Список пустий");
                this.Close();
                return;
            }
            else
            {
                ListViewItem item = null;
                foreach (var book in booksFiltred)
                {
                    item = new ListViewItem(new string[] { book.Name, book.Author.Name + " " + book.Author.Surname, Convert.ToString(book.PublicationYear), book.Genre });
                    BookListView.Items.Add(item);
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            Dictionary<Book, int> BookIndex = new Dictionary<Book, int>();
            if (BookListView.SelectedItems.Count != 0)
            {
                if (BookListView.SelectedItems.Count > quantityOfAvaibleBooks)
                {
                    MessageBox.Show("Недостатня кількість доступних книг");
                    return;
                }
                for (int i = 0; i < BookListView.SelectedItems.Count; i++)
                {
                    // WantedBooks.Add(booksFiltred[BookListView.SelectedItems[i].Index]);
                    BookIndex.Add(booksFiltred[BookListView.SelectedItems[i].Index], BookListView.SelectedItems[i].Index);
                }
                CartForm form = new CartForm(BookIndex, client);
                this.Visible = false;
                this.Close();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Виберіть хоча б одну книгу");
            }
        }
    }
}
