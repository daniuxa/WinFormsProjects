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
    public partial class SuccessfulOrderForm : Form
    {
        private Client client;
        private WorkingWithFiles<List<Client>> workingWithFiles;
        private List<Client> clients;
        public SuccessfulOrderForm()
        {
            InitializeComponent();
        }
        public SuccessfulOrderForm(Client client)
        {
            InitializeComponent();
            this.client = client;
            workingWithFiles = new WorkingWithFiles<List<Client>>();
        }

        private void SuccessfulOrderForm_Load(object sender, EventArgs e)
        {
            ListViewItem item = null;
            foreach (var book in client.cart.books)
            {
                item = new ListViewItem(new string[] { book.Key._name, book.Key._author, Convert.ToString(book.Key._ProductionYear), book.Key._Genre, book.Value.AddMonths(1).ToString("d") });
                CartListView.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            clients = workingWithFiles.ReadingFromFile("Clients.bin");
            //workingWithFiles.ReadingFromFile();
            clients.Add(client);
            workingWithFiles.WritingToFile(clients, "Clients.bin");
            Application.Exit();
        }
    }
}
