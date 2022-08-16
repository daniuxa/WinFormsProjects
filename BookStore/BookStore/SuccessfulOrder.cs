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

namespace BookStore
{
    public partial class SuccessfulOrder : Form
    {
        private Client client;
        public SuccessfulOrder(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void SuccessfulOrder_Load(object sender, EventArgs e)
        {
            ListViewItem item = null;
            foreach (var book in client.cart.books)
            {
                item = new ListViewItem(new string[] { book.Name, book.Author.Name + " " + book.Author.Surname, Convert.ToString(book.PublicationYear), Convert.ToString(book.Price), book.Genre });
                CartListView.Items.Add(item);
            }
            SumLabel.Text += client.cart.GetSum().ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\BookStore\BookStore\Lists\Clients.bin", FileMode.OpenOrCreate))
            {
                clients = (List<Client>)formatter.Deserialize(fs);
            }
            clients.Add(client);
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\BookStore\BookStore\Lists\Clients.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, clients);
            }
            Application.Exit();
        }
    }
}
