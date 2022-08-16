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
    delegate void ErrorMsg();
    public partial class FilterForm : Form
    {
        private Cart cart = null;
        public FilterForm()
        {
            InitializeComponent();
        }

        public FilterForm(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void YearText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthorText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Book SearchBook = null;
            ErrorMsg errorMsg = CheckError(ref SearchBook);
            errorMsg?.Invoke(); //errorMsg();
            //if (errorMsg != null)
                //errorMsg();
            BookListForm form = new BookListForm(SearchBook, cart);
           form.ShowDialog();
                //MessageBox.Show($"Назва книги: {SearchBook._name}\nАвтор: {SearchBook._author}\nРік написання: {SearchBook._ProductionYear}\nЖанр: {SearchBook._Genre}");
            
        }
        private ErrorMsg CheckError(ref Book SearchBook)
        {
            bool check = int.TryParse(YearText.Text, out int Year);
            string genre;
            ErrorMsg errorMsg = null;
            if (YearText.Text == "")
            {
                Year = 0;
            }
            if (GenreText.Text == "")
                genre = "По замовченню";
            else
                genre = GenreText.Text;

            if (YearText.Text != "" && (!check || Year > DateTime.Now.Year || Year <= 1))
            {
                errorMsg = () =>  MessageBox.Show("Неправильно введений рік"); 
                return errorMsg;
            }
            else
            {
                //MessageBox.Show($"{AuthorText.Text}\n{GenreText.Text}\n{NameText.Text}\n{YearText.Text}");
                try
                {
                    SearchBook = new Book(NameText.Text, AuthorText.Text, Year, genre);
                }
                catch (ProdYearException ex)
                {
                    errorMsg = delegate () 
                    { 
                        MessageBox.Show($"{ex.Message}\t Значення:{ex.Value}"); 
                    };
                    
                }
                catch (GenreException ex)
                {
                    errorMsg = delegate ()
                    {
                        MessageBox.Show($"{ex.Message}\t Значення:{ex.Value}");
                    };
                }
                return errorMsg;
                /*BookListForm form = new BookListForm(SearchBook);
                form.ShowDialog();*/
                //MessageBox.Show($"Назва книги: {SearchBook._name}\nАвтор: {SearchBook._author}\nРік написання: {SearchBook._ProductionYear}\nЖанр: {SearchBook._Genre}");
            }
        }
    }
}
