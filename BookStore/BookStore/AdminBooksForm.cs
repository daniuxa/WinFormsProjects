using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AdminBooksForm : Form
    {
        List<Book> books;
        public AdminBooksForm(List<Book> books)
        {
            InitializeComponent();
            this.books = books;
        }

        private void AdminBooksForm_Load(object sender, EventArgs e)
        {
            int Sum = 0;
            ListViewItem item = null;
            foreach (var book in books)
            {
                item = new ListViewItem(new string[] { book.Name, book.Author.Name + " " + book.Author.Surname, Convert.ToString(book.PublicationYear), Convert.ToString(book.Price), book.Genre });
                CartListView.Items.Add(item);
                Sum += book.Price;
            }
            SumLabel.Text += Sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
