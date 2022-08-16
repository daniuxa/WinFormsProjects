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
    public partial class ClientInfoEntry : Form
    {
        private List<Client> clients = new List<Client>();
        private Cart cart;
        public ClientInfoEntry(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Client client = null;
            if (NameTextBox.Text != "" && SurnameTextBox.Text != "" && PhoneTextBox.Text != "" && EmailTextBox.Text != "")
            {
                try
                {
                    client = new Client(NameTextBox.Text, SurnameTextBox.Text, PhoneTextBox.Text, EmailTextBox.Text, cart);
                }
                catch(EmailException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex}");
                }
                catch(PhoneException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex}");
                }
                this.Visible = false;
                SuccessfulOrder form = new SuccessfulOrder(client);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Перевірте правильність вводу");
            }
        }

        private void ClientInfoEntry_Load(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\BookStore\BookStore\Lists\Clients.bin", FileMode.OpenOrCreate))
            {
                clients = (List<Client>)formatter.Deserialize(fs);
            }
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            if (clients.Count != 0)
            {
                foreach(var client in clients)
                {
                    source.Add(client.Name);
                }

                NameTextBox.AutoCompleteCustomSource = source;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            if (clients.Count != 0)
            {
                foreach (var client in clients)
                {
                    if (client.Name == NameTextBox.Text)
                        source.Add(client.Surname);
                }
                SurnameTextBox.AutoCompleteCustomSource = source;
            }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            AutoCompleteStringCollection source1 = new AutoCompleteStringCollection();
            if (clients.Count != 0)
            {
                foreach (var client in clients)
                {
                    if (client.Name == NameTextBox.Text && client.Surname == SurnameTextBox.Text)
                    {
                        source.Add(client.PhoneNumber);
                        source1.Add(client.Email);
                    }                      
                }
                PhoneTextBox.AutoCompleteCustomSource = source;
                EmailTextBox.AutoCompleteCustomSource = source1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
