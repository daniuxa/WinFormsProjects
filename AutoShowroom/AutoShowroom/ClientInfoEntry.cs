using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShowroom
{
    public partial class ClientInfoEntry : Form
    {
        private Vehicle vehicle;
        public ClientInfoEntry()
        {
            InitializeComponent();
        }
        public ClientInfoEntry(Vehicle vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;
        }

        private void ClientInfoEntry_Load(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Client сustomer;
            if (NameTextBox.Text != "" && SurnameTextBox.Text != "" && SexBox.Text != "" && PhoneTextBox.Text != "")
            {
                try
                {
                    сustomer = new Client(NameTextBox.Text, SurnameTextBox.Text, PhoneTextBox.Text, VisitDayTimePicker.Value, vehicle);
                }
                catch (PhoneNumberException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                    return;
                }
                catch (VisitDateException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value.ToString("d")}");
                    return;
                }
                this.Visible = false;
                SuccessfulOrder Form = new SuccessfulOrder(сustomer);
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Перевірте правильність заповнення полей");
            }
        }
    }
}
