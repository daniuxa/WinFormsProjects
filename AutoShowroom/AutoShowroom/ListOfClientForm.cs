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
    public partial class ListOfClientForm : Form
    {
        List<Client> clients;
        FileClass<List<Client>> fileListClient;
        public ListOfClientForm()
        {
            InitializeComponent();
        }

        private void ListOfClientForm_Load(object sender, EventArgs e)
        {
            fileListClient = new FileClass<List<Client>>();
            AddClientToList(fileListClient.ReadingFromFile);
        }
        private void AddClientToList(ReadingList<Client> readingListClient)
        {
            try
            {
                clients = readingListClient(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Client.bin");
            }
            catch (FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                return;
            }
            ListViewItem item = null;
            foreach (var client in clients)
            {
                item = new ListViewItem(new string[] { client.Name, client.Surname, client.PhoneNumber, client.VisitDate.ToString("d"), client.ViewVehicle.Brand + " " + client.ViewVehicle.Model + " " + client.ViewVehicle.ProductionYear.ToString() });
                ClientListView.Items.Add(item);
            }
        }
/*        private List<Client> ReadingFromFileClients()
        {
            List<Client> clients = null;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Client.bin", FileMode.OpenOrCreate))
            {
                clients = (List<Client>)formatter.Deserialize(fs);
            }
            return clients;
        }*/

        private void DetailInfoButton_Click(object sender, EventArgs e)
        {
            Client client;
            
            if (ClientListView.SelectedItems.Count == 1)
            {
                client = clients[ClientListView.SelectedItems[0].Index];
                if (client.ViewVehicle.GetType().Name == "Car")
                {
                    Car car = client.ViewVehicle as Car;
                    MessageBox.Show($"Тип транспорту: Автомобіль\n\nБренд: {car.Brand}\n\nМодель: {car.Model}\n\nРік виготовлення: {car.ProductionYear}\n\nЦіна: {car.Price}\n\nТип кузова: {car.BodyType}");
                }
                else
                {
                    Moto moto = client.ViewVehicle as Moto;
                    MessageBox.Show($"Тип транспорту: Мотоцикл\n\nБренд: {moto.Brand}\n\nМодель: {moto.Model}\n\nРік виготовлення: {moto.ProductionYear}\n\nЦіна: {moto.Price}\n\nТип мотоцикла: {moto.TypeMoto}");
                }            
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Client clientRemove;
            if (ClientListView.SelectedItems.Count == 1)
            {
                clientRemove = clients[ClientListView.SelectedItems[0].Index];
                clients.Remove(clientRemove);
                ClientListView.Items.Clear();
                //BinaryFormatter formatter = new BinaryFormatter();
                ListViewItem item = null;
                foreach (var client in clients)
                {
                    item = new ListViewItem(new string[] { client.Name, client.Surname, client.PhoneNumber, client.VisitDate.ToString("d"), client.ViewVehicle.Brand + " " + client.ViewVehicle.Model + " " + client.ViewVehicle.ProductionYear.ToString() });
                    ClientListView.Items.Add(item);
                }
                try
                {
                    fileListClient.WritingToFile(clients, @"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Client.bin");
                }
                catch (FileException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                    return;
                }
                /*using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Client.bin", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, clients);
                }*/
            }
        }
    }
}
