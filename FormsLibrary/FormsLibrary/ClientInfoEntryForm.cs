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
    public partial class ClientInfoEntryForm : Form
    {
        private Cart cart;
        public ClientInfoEntryForm(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Client client = null;
            if (NameTextBox.Text != "" && SurnameTextBox.Text != "" && PhoneTextBox.Text != "")
            {
                try
                {
                    client = new Client(NameTextBox.Text, SurnameTextBox.Text, PhoneTextBox.Text, cart);
                }
                catch (PhoneException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                }
                this.Visible = false;
                SuccessfulOrderForm form = new SuccessfulOrderForm(client);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Перевірте правильність вводу");
            }
        }
    }
}
