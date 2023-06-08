using BookCrossing.Entities;
using BookCrossing.Exceptions;
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
    delegate void ErrorMsg();
    public partial class FilterForm : Form
    {
        private Client client;              //Потичний клієнт
        private Book book;                  //Книга для фільтрації
        private List<Book> WantedBooks;     //Книги, які клієнт хоче взяти
        private int quantityOfAvaibleBooks = 0;//Кількість книг доступних, щоб взяти
        public FilterForm(int quantity, Client client)
        {
            InitializeComponent();
            quantityOfAvaibleBooks = quantity;
            this.client = client;
        }
        public FilterForm(List<Book> WantedBooks, Client client, int quantity)
        {
            InitializeComponent();
            this.WantedBooks = WantedBooks;
            this.client = client;
            quantityOfAvaibleBooks = quantity;
        }
        private void YearError()
        {
            MessageBox.Show("Неправильно введено рік", "Помилка вводу року", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private ErrorMsg CheckError()
        {
            ErrorMsg msg = null;
            bool check = int.TryParse(YearText.Text, out int Year);
            string genre;
            Person author = null;
            string Author = "";
            string[] AuthorArr;
            string NameAuthor = "";
            string SurnameAuthor = "";
            if (AuthorText.Text != "")
            {
                Author = String.Join(" ", AuthorText.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
                AuthorArr = Author.Split(' ');
                if (AuthorArr.Length == 2)
                {
                    NameAuthor = AuthorArr[0];
                    SurnameAuthor = AuthorArr[1];
                }
                else
                {
                    NameAuthor = Author;
                }
                author = new Person(NameAuthor, SurnameAuthor);
            }
            if (YearText.Text == "")
            {
                Year = 0;
            }
            if (GenreText.Text == "")
                genre = "По замовченню";
            else
                genre = GenreText.Text;
           

            if (YearText.Text != "" && (!check || Year > DateTime.Now.Year || Year < 1))
            {
                msg = YearError;
                return msg;
            }
            else
            {
                try
                {
                    book = new Book(NameText.Text, author, Year, genre);
                }

                catch (PublicationYearException ex)
                {
                    msg = () =>
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення:{ex.Value}");
                    return msg;
                }
            }
            return msg;
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            ErrorMsg msg;                   //Обьект делегаты
            msg = CheckError();             //присваиваем функцию
            if (msg != null) //msg?.Invoke();//Проверка на то присвоилась функция делегате
            {
                msg();                       //Вызов делегаты
            }
            else
            {
                this.Visible = false;
                BookList form = new BookList(WantedBooks, book, quantityOfAvaibleBooks, client);
                form.ShowDialog();
            }
        }
    }
}
