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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Click(object sender, EventArgs e)
        {
            FilterForm Form1 = new FilterForm();
            Form1.Show();
        }

        private void SearchMain_Click(object sender, EventArgs e)
        {
            if (NameMain.Text == "")
                MessageBox.Show("Введіть назву книжки");
            else
            {
                Book SearchBook = new Book(NameMain.Text, "", 0, "По замовченню");
                //MessageBox.Show($"Назва книги: {SearchBook._name}");
                BookListForm form = new BookListForm(SearchBook, null);
                form.ShowDialog();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            ListBookButton.Visible = false;
            ListClientButton.Visible = false;
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.Transparent)
            {
                AdminButton.BackColor = Color.LightBlue;
                panel1.BackColor = Color.LightBlue;
                ListBookButton.Visible = true;
                ListClientButton.Visible = true;
            }
            else
            {
                AdminButton.BackColor = Color.WhiteSmoke;
                panel1.BackColor = Color.Transparent;
                ListBookButton.Visible = false;
                ListClientButton.Visible = false;
            }
        }

        private void ListClientButton_Click(object sender, EventArgs e)
        {
            ListClientForm form = new ListClientForm();
            form.ShowDialog();
        }

        private void ListBookButton_Click(object sender, EventArgs e)
        {
            AdminBookForm adminBookForm = new AdminBookForm();
            adminBookForm.ShowDialog();
        }
    }
}
