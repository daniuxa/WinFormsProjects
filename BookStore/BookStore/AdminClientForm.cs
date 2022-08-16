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
    public partial class AdminClientForm : Form
    {
        List<Client> clients;
        public AdminClientForm()
        {
            InitializeComponent();
        }

        private void AdminClientForm_Load(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\BookStore\BookStore\Lists\Clients.bin", FileMode.OpenOrCreate))
            {
                clients = (List<Client>)formatter.Deserialize(fs);
            }
            ListViewItem item = null;
            foreach (var client in clients)
            {
                item = new ListViewItem(new string[] {  client.Name, client.Surname, client.PhoneNumber, client.Email});
                ClientListView.Items.Add(item);
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            List<Book> clientBooks;
            if (ClientListView.SelectedItems.Count == 1)
            {
                clientBooks = clients[ClientListView.SelectedItems[0].Index].cart.books;
                AdminBooksForm form = new AdminBooksForm(clientBooks);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Виберіть клієнта");
            }
        }

        private void ClientListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
