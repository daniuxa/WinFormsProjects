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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterForm form = new FilterForm(null);
            form.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                Book book = new Book(SearchBox.Text, null, 0, 0, "По замовченню");
                BookList form = new BookList(book, book, null);
                form.ShowDialog();
            }
            else
                MessageBox.Show("Рядок пошуку пустий");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminClientForm form = new AdminClientForm();
            form.ShowDialog();
        }
    }
}
