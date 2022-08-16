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
    delegate List<T> ReadingList<T>(string path);
    //ReadingVehicleList foo = Message;
    //foo(1);
    //foo.Invoke(1);
    public partial class ListForm : Form
    {
        private List<Vehicle> vehiclesFiltred;
        private Vehicle vehicleTo;
        private Vehicle vehicleFrom;
        private FileClass<List<Vehicle>> fileListVehicle;
        public ListForm()
        {
            InitializeComponent();
        }

        public ListForm(Vehicle vehicleFrom, Vehicle vehicleTo)
        {
            InitializeComponent();
            this.vehicleFrom = vehicleFrom;
            this.vehicleTo = vehicleTo;
        }
        private void AddCarsToList(List<Vehicle> vehicles)
        {
            ListViewItem item = null;
            foreach (var vehicle in vehicles)
            {
                if ((vehicle as Car) != null)
                    item = new ListViewItem(new string[] { vehicle.Brand, vehicle.Model, Convert.ToString(vehicle.ProductionYear), Convert.ToString(vehicle.Price), (vehicle as Car).BodyType });
                else
                    item = new ListViewItem(new string[] { vehicle.Brand, vehicle.Model, Convert.ToString(vehicle.ProductionYear), Convert.ToString(vehicle.Price), (vehicle as Moto).TypeMoto });
                VehicleList.Items.Add(item);
            }
        }
        private void ListForm_Load(object sender, EventArgs e)
        {
            fileListVehicle = new FileClass<List<Vehicle>>();
            if ((vehicleFrom as Car) == null)
            {
                VehicleList.Columns.Add("Тип мотоцикла");
            }
            else
            {
                VehicleList.Columns.Add("Тип кузова");
            }

            vehiclesFiltred = FiltringVehicleList(fileListVehicle.ReadingFromFile);
            if (vehiclesFiltred.Count != 0)
                AddCarsToList(vehiclesFiltred);
            else
            {
                MessageBox.Show("Не знайдено необхідного транспортного засобу");
                this.Close();
            }
        }

        private List<Vehicle> FiltringVehicleList(ReadingList<Vehicle> readingVehicleList)
        {
           List<Vehicle> vehiclesFiltred = new List<Vehicle>();
            List<Vehicle> vehicles = null;
            try
            {
                vehicles = readingVehicleList(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Vehicles.bin");
            }
            catch (FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                return null;
            }

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Filter(vehicleFrom, vehicleTo) == true)
                {
                    vehiclesFiltred.Add(vehicle);
                }
            }
            return vehiclesFiltred;
        }
        /*private List<Vehicle> ReadFromFileVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\AutoShowroom\\AutoShowroom\\Files\\Vehicles.bin", FileMode.OpenOrCreate))
            {
                vehicles = (List<Vehicle>)formatter.Deserialize(fs);
            }
            return vehicles;
        }*/

        private void SelectButton_Click(object sender, EventArgs e)
        {
            Vehicle vehicle;
            if (VehicleList.SelectedItems.Count == 1)
            {
                vehicle = vehiclesFiltred[VehicleList.SelectedItems[0].Index];
                this.Visible = false;
                ClientInfoEntry form = new ClientInfoEntry(vehicle);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Перевірте ввід даних");
            }
        }
    }
}
