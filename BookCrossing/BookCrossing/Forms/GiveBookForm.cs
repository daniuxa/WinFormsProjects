using BookCrossing.Entities;
using BookCrossing.Exceptions;
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
    public partial class GiveBookForm : Form
    {
        private Client client;                             //Потичний клієнт
        private List<Book> books = new List<Book>();       //Всі книги, які є на сервісі 
        private List<Client> clients = new List<Client>(); //Всі клієнти 
        private Book book;                                 //Книга, яку хочуемо віддати
        public GiveBookForm()
        {
            InitializeComponent();
        }
        public GiveBookForm(Client client)
        {
            InitializeComponent();
            this.client = client;   
        }

        private void GiveBookForm_Load(object sender, EventArgs e)
        {
            books = ReadBooks();
            clients = ReadClients();
        }

        private void GiveBookButton_Click(object sender, EventArgs e)
        {
            int YearPublication;
            if (NameTextBox.Text == "" || AuthorNameTextBox.Text == "" || SurnameTextBox.Text == "" || YearPublTextBox.Text == "" || GenreTextBox.Text == "")
            {
                MessageBox.Show("Поля не можуть бути пустими");
                return;
            }
            if (Int32.TryParse(YearPublTextBox.Text, out YearPublication) == false)
            {
                MessageBox.Show("Неправильно введений рік");
                return;
            }
            try
            {
                book = new Book(NameTextBox.Text, new Person(AuthorNameTextBox.Text, SurnameTextBox.Text), YearPublication, GenreTextBox.Text);
            }
            catch (PublicationYearException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
            }
            clients = clients.Where(x => x.ClientAccount.LogIn != client.ClientAccount.LogIn).ToList();

            client.cart.AddGivenBook(book);
            clients.Add(client);
            WriteClients(clients);
            books.Add(book);
            WriteBooks(books);
            this.Close();
            AccountForm form = new AccountForm(client);
            this.Visible = false;
            this.Close();
            form.ShowDialog();
        }
        private List<Client> ReadClients()
        {
            List<Client> clients = new List<Client>();
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Clients.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                clients = (List<Client>)formatter.Deserialize(fs);
            }
            return clients;
        }
        private void WriteClients(List<Client> clients)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Clients.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, clients);
            }
        }
        private List<Book> ReadBooks()
        {
            List<Book> books = new List<Book>();
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Books.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                books = (List<Book>)formatter.Deserialize(fs);
            }
            return books;
        }
        private void WriteBooks(List<Book> books)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Books.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, books);
            }
        }
    }
}
