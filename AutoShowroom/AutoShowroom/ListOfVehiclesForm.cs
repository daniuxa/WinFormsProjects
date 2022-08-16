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
    public partial class ListOfVehiclesForm : Form
    {
        List<Vehicle> vehicles;
        FileClass<List<Vehicle>> fileListVehicle;
        public ListOfVehiclesForm()
        {
            InitializeComponent();
        }

        private void ListOfVehiclesForm_Load(object sender, EventArgs e)
        {
            fileListVehicle = new FileClass<List<Vehicle>>();
            AddVehiclesToList(fileListVehicle.ReadingFromFile);
        }
        private void AddVehiclesToList(ReadingList<Vehicle> readingList)
        {
            try
            {
                vehicles = readingList(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Vehicles.bin");
            }
            catch (FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                return;
            }
            
            ListViewItem item = null;
            foreach(var vehicle in vehicles)
            {
                item = new ListViewItem(new string[] { vehicle.GetType().Name == "Car" ? "Автомобіль" : "Мотоцикл", vehicle.Brand, vehicle.Model, Convert.ToString(vehicle.ProductionYear), Convert.ToString(vehicle.Price)});
                VehicleListView.Items.Add(item);
            }
        }
       /* private List<Vehicle> ReadingFromFile()
        {
            List<Vehicle> vehicles;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Vehicles.bin", FileMode.OpenOrCreate))
            {
                vehicles = (List<Vehicle>)formatter.Deserialize(fs);
            }
            return vehicles;
        }*/

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicleForm form = new AddVehicleForm(ref vehicles);
            form.ShowDialog();
            ListViewItem item = null;
            foreach (var vehicle in vehicles)
            {
                item = new ListViewItem(new string[] { vehicle.GetType().Name == "Car" ? "Автомобіль" : "Мотоцикл", vehicle.Brand, vehicle.Model, Convert.ToString(vehicle.ProductionYear), Convert.ToString(vehicle.Price) });
                VehicleListView.Items.Add(item);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Vehicle vehicleRemove;
            if (VehicleListView.SelectedItems.Count == 1)
            {
                vehicleRemove = vehicles[VehicleListView.SelectedItems[0].Index];
                vehicles.Remove(vehicleRemove);
                VehicleListView.Items.Clear();
                ListViewItem item = null;
                foreach (var vehicle in vehicles)
                {
                    item = new ListViewItem(new string[] { vehicle.GetType().Name == "Car" ? "Автомобіль" : "Мотоцикл", vehicle.Brand, vehicle.Model, Convert.ToString(vehicle.ProductionYear), Convert.ToString(vehicle.Price) });
                    VehicleListView.Items.Add(item);
                }
                try
                {
                    fileListVehicle.WritingToFile(vehicles, @"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Vehicles.bin");
                }
                catch(FileException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                    return;
                }
                /*BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Vehicles.bin", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, vehicles);
                }*/
            }
            else
            {
                MessageBox.Show("Виберіть один транспорт");
            }
        }
    }
}
