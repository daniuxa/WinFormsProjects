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
    public partial class LogInForm : Form
    {
        private List<Client> clients = new List<Client>();  //Всі клієнти
        private Client ActiveClient;                        //Потичний клієнт
        public LogInForm()
        {
            InitializeComponent();
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Clients.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                clients = (List<Client>)formatter.Deserialize(fs);
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            ActiveClient = clients.Where(x => x.ClientAccount.LogIn == LoginTextBox.Text && x.ClientAccount.Password == PasswordTextBox.Text).FirstOrDefault();
            if (ActiveClient == null)
            {
                MessageBox.Show("Немає такого акаунту");
                return;
            }
            else
            {
                AccountForm form = new AccountForm(ActiveClient);
                this.Close();
                form.ShowDialog();
            }
        }
    }
}
