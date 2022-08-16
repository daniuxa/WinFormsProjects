using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLibrary
{
    public partial class AdminBookForm : Form
    {
        WorkingWithFiles<List<Book>> workingWithFiles;
        Dictionary<Book, DateTime> books = null;
        List<Book> Books;
        Queue<string> queue = new Queue<string>();
        public AdminBookForm(Dictionary<Book, DateTime> books)
        {
            InitializeComponent();
            this.books = books;
        }
        public AdminBookForm()
        {
            InitializeComponent();
            workingWithFiles = new WorkingWithFiles<List<Book>>();
            Books = workingWithFiles.ReadingFromFile("Books.bin");
        }

        private void AdminBookForm_Load(object sender, EventArgs e)
        {
            if (books != null)
                AddDictionaryBookToListView(books, ChangeBackGroundColor);
            else
            {
                Queue<Book> books = new Queue<Book>();
                CartListView.Columns.Remove(DateReutnBook);
                CartListView.Columns.Remove(DateTakenBook);
                foreach (var book in Books)
                {
                    books.Enqueue(book);
                }
                AddListBookToListView(books, ChangeBackGroundColor);
            }
                


        }
        private void AddDictionaryBookToListView(Dictionary<Book, DateTime> books, ChangeStyle changeStyleBookLines)
        {
            ListViewItem item = null;
            foreach (var book in books)
            {
                item = new ListViewItem(new string[] { book.Key._name, book.Key._author, book.Key._ProductionYear.ToString(), book.Key._Genre, book.Value.ToString("d"), book.Value.AddMonths(1).ToString("d") }) ;
                changeStyleBookLines(item, Color.LightGray);
                //changeStyleBookLines(item, Color.Black);
                CartListView.Items.Add(item);
            }
        }
        private void AddListBookToListView(Queue<Book> books, ChangeStyle changeStyleBookLines)
        {
            ListViewItem item = null;
            while (books.Count != 0)
            {
                Book book = books.Dequeue();
                item = new ListViewItem(new string[] { book._name, book._author, book._ProductionYear.ToString(), book._Genre});
                changeStyleBookLines(item, Color.LightGray);
                //changeStyleBookLines(item, Color.Black);
                CartListView.Items.Add(item);
            }
        }
        private void ChangeBackGroundColor(ListViewItem item, Color color)
        {
            item.SubItems[0].BackColor = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
