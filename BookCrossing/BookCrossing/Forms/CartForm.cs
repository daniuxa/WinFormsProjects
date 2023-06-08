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
    public partial class CartForm : Form
    {
        private List<Book> books = new List<Book>();        //Книги в кошику
        private List<Client> clients = new List<Client>();  //Всі клієнти, які є на сервірі
        private Dictionary<Book, int> BookIndex;            //Книга і її індекс у списку, які клієнт хоче замовити
        private Client client;                              //Потичний клієнт
        public CartForm(Dictionary<Book, int> BookIndex, Client client)
        {
            InitializeComponent();
            this.BookIndex = BookIndex;
            books = ReadBooks();
            this.client = client;
            clients = ReadClients();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            ListViewItem item = null;
            foreach (var book in BookIndex)
            {
                item = new ListViewItem(new string[] { book.Key.Name, book.Key.Author.Name + " " + book.Key.Author.Surname, Convert.ToString(book.Key.PublicationYear), book.Key.Genre });
                CartListView.Items.Add(item);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Book bookRemove;
            if (BookIndex.Count() != 0)
            {
                if (CartListView.SelectedItems.Count == 1)
                {
                    bookRemove = BookIndex.Skip(CartListView.SelectedItems[0].Index).First().Key;
                    BookIndex.Remove(bookRemove);                  
                }
                CartListView.Items.Clear();
                ListViewItem item = null;
                foreach (var book in BookIndex)
                {
                    item = new ListViewItem(new string[] { book.Key.Name, book.Key.Author.Name + " " + book.Key.Author.Surname, Convert.ToString(book.Key.PublicationYear), book.Key.Genre });
                    CartListView.Items.Add(item);
                }
                
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (BookIndex.Count() != 0)
            {
                List<Book> NewBooks = new List<Book>(); 
                List<int> RemoveClients = new List<int>(); 
                clients = clients.Where(x => x.ClientAccount.LogIn != client.ClientAccount.LogIn).ToList();

                for (int i = 0; i < books.Count(); i++)
                {
                    if (BookIndex.ContainsValue(i) == false)
                    {
                        NewBooks.Add(books[i]);
                    }
                }
                books = NewBooks;
                WriteBooks(books);
                foreach (var item in BookIndex)
                {
                    client.cart.AddTakenBook(item.Key);
                }
                clients.Add(client);
                WriteClients(clients);
                
                ConfirmationForm form = new ConfirmationForm();
                this.Visible = false;
                this.Close();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Корзина пуста");
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
    }
}
