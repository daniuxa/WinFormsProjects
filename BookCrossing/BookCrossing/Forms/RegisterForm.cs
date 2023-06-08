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
    public partial class RegisterForm : Form
    {
        private List<Client> clients = new List<Client>(); //Всі клієнти
        private Client NewClient;                          //Новий клієнт
        public RegisterForm()
        {
            InitializeComponent();
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Clients.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                clients = (List<Client>)formatter.Deserialize(fs);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || SurnameTextBox.Text == "" || LoginTextBox.Text == "" || PasswordTextBox.Text == "" || PhoneTextBox.Text == "")
            {
                MessageBox.Show("Поля не можуть бути пустими");
                return;
            }
            if (PasswordTextBox.Text.Length < 5)
            {
                MessageBox.Show("Довжина пароля не може бути менше 5 символів");
                return;
            }
            if (clients.Exists(x => x.ClientAccount.LogIn == LoginTextBox.Text))
            {
                MessageBox.Show("Користувач з даним логіном вже існує");
                return;
            }

            try
            {
                NewClient = new Client(NameTextBox.Text, SurnameTextBox.Text, PhoneTextBox.Text, new ClientAccount(LoginTextBox.Text, PasswordTextBox.Text));
            }
            catch (PhoneException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                return;
            }
            clients.Add(NewClient);
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Clients.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, clients);
            }
            MessageBox.Show("Успішно зареєстровано");
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
