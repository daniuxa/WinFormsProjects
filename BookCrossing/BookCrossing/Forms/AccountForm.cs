using BookCrossing.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCrossing.Forms
{
    public partial class AccountForm : Form
    {
        private Client ActiveClient;                //Потичний клієнт
        private int quantityOfAvaibleBooks = 0;     //Кількість книг доступних, щоб взяти
        public AccountForm()
        {
            InitializeComponent();
        }

        public AccountForm(Client client)
        {
            InitializeComponent();
            ActiveClient = client;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            AccountLabel.Text += ActiveClient.ClientAccount.LogIn;                  //Записуємо логін користувача на формі
            CountTakenBooksLabel.Text += ActiveClient.cart.CountTakenBook();        //Записуємо кількість взятих книг на формі
            CountGivenBooksLabel.Text += ActiveClient.cart.CountGivenBook();        //Записуємо кількість відданих книг на формі
            quantityOfAvaibleBooks = ActiveClient.cart.CountGivenBook() - ActiveClient.cart.CountTakenBook(); //Підраховуємо кількість доступних книг, щоб взяти
        }

        private void TakeBooksButton_Click(object sender, EventArgs e)
        {
            if (quantityOfAvaibleBooks > 0)  //Якщо кількість доступних книг, щоб взяти, більша 0
            {
                FilterForm filterForm = new FilterForm(quantityOfAvaibleBooks, ActiveClient);
                this.Visible = false;
                this.Close();
                filterForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не достатньо відданих книг");
            }
            
        }

        private void GiveBooksButton_Click(object sender, EventArgs e)
        {
            GiveBookForm form = new GiveBookForm(ActiveClient);
            this.Visible = false;
            this.Close();
            form.ShowDialog();
        }
    }
}
