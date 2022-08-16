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

namespace AutoShowroom
{
    /*delegate void BoughtCar(object sender, BoughtCarEventArg BoughtCar);
     delegate void AddedCar(object sender, AddeCarEventArg AddedCar)*/
    public partial class SuccessfulOrder : Form
    {
        public event EventHandler<BoughtVehicleEventArg> BoughtVehicle;
        private Client client;

        public SuccessfulOrder()
        {
            InitializeComponent();
            //BoughtVehicle += SendMessage; //+= ----- BoughtVehicle.Add(SendMessage)
                                          //-= ----- BoughtVehicle.Remove(SendMessage)
        }
        public SuccessfulOrder(Client client)
        {
            BoughtVehicle += SendMessage;
            InitializeComponent();
            this.client = client;
        }

        private void SuccessfulOrder_Load(object sender, EventArgs e)
        {
            CustomerName.Text += client.Name;
            Surname.Text += client.Surname;
            Phone.Text += client.PhoneNumber;
           VisitDate.Text += client.VisitDate.ToString("d");

            BoughtVehicle?.Invoke(client, new BoughtVehicleEventArg(client.ViewVehicle, DateTime.Now));
        }
        static void SendMessage(object sender, BoughtVehicleEventArg BoughtVehicleEventArg)
        {
            Client client = sender as Client;
            if (client != null)
                MessageBox.Show($"На сайті замовлен транспортний засіб: {BoughtVehicleEventArg.vehicle.Brand} {BoughtVehicleEventArg.vehicle.Model} {BoughtVehicleEventArg.vehicle.ProductionYear} року\n\nЧас покупки: {BoughtVehicleEventArg.BoughtTime.ToString("G")}\n\nПокупець: {client.Name} {client.Surname} \n\nМобільний телефон: {client.PhoneNumber}\n\n Дата візиту: {client.VisitDate.ToString("d")}", "Повідомлення адміністратору", MessageBoxButtons.OK);
        }
        private void OKButtn_Click(object sender, EventArgs e)
        {
            List<Client> clients;
            FileClass<List<Client>> fileListClient = new FileClass<List<Client>>();
            try
            {
                clients = fileListClient.ReadingFromFile(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Client.bin");
            }
            catch(FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                return;
            }

            clients.Add(client);

            try
            {
                fileListClient.WritingToFile(clients, @"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Client.bin");
            }
            catch (FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                return;
            }
            /*BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Client.bin", FileMode.OpenOrCreate))
            {
                clients = (List<Client>)formatter.Deserialize(fs);
            }
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Client.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, clients);
            }*/
            //Application.Exit();
            this.Close();
        }
    }
}
