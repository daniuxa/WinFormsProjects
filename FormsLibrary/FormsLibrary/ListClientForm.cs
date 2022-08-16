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
    public partial class ListClientForm : Form
    {
        WorkingWithFiles<List<Client>> workingWithFiles;
        List<Client> clients;
        Stack<Client> clients1;

        public ListClientForm()
        {
            InitializeComponent();
            workingWithFiles = new WorkingWithFiles<List<Client>>();
            clients1 = new Stack<Client>();
        }

        private void ListClientForm_Load(object sender, EventArgs e)
        {
            clients = workingWithFiles.ReadingFromFile("Clients.bin");
            if (clients == null)
            {
                MessageBox.Show("Не вдалося зчитати файл");
                return;
            }
            foreach (var client in clients)
            {
                clients1.Push(client);
            }
            clients.Reverse();
            AddClientToListView(clients1, ChangeBackGroundColor);
        }
        private void ChangeBackGroundColor(ListViewItem item, Color color)
        {
            item.SubItems[0].BackColor = color;
        }
        private void AddClientToListView(Stack<Client> clients, ChangeStyle changeStyleBookLines)
        {
            ClientListView.Items.Clear();
            ListViewItem item = null;
            Client client1;
            while (clients.Count != 0)
            {
                client1 = clients.Pop();
                item = new ListViewItem(new string[] { client1._name, client1._surname, client1._Phone });
                changeStyleBookLines(item, Color.LightGray);
                ClientListView.Items.Add(item);
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Dictionary<Book, DateTime> clientBooks;
            if (ClientListView.SelectedItems.Count == 1)
            {
                clientBooks = clients[ClientListView.SelectedItems[0].Index].cart.books;
                AdminBookForm form = new AdminBookForm(clientBooks);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Виберіть клієнта");
            }
        }
    }
}
