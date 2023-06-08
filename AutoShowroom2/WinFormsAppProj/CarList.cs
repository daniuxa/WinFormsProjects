﻿using System;
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

namespace WinFormsAppProj
{
    delegate List<T> EntryList<T>();
    public partial class CarList : Form
    {
        private List<Car> carsFiltred;
        private InAndOutputLists<List<Car>> readingLists;

        public Car carFrom { get; set; }
        public Car carTo { get; set; }

        public CarList()
        {
            InitializeComponent();
            carsFiltred = new List<Car>();
            readingLists = new InAndOutputLists<List<Car>>();
            readingLists.ChangeFilePath("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Cars.bin");
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point LastPoint;

        private void TopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }

        }

        private void TopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        

        
        private void AddCarsToList(List<Car> Cars)
        {
            ListViewItem item = null;
            foreach (var Car in Cars)
            {
                item = new ListViewItem(new string[] { Car.Brand, Car.Model, Convert.ToString(Car.ProductionYear), Convert.ToString(Car.Price), Car.Engine.Type, Convert.ToString(Car.Engine.Power), Convert.ToString(Car.Engine.Volume) });
                CarListView.Items.Add(item);
            }
        }
        private void CarList_Load(object sender, EventArgs e)
        {
            carsFiltred = FiltringCarList(readingLists.ReadingFromFile);
            
            if (carsFiltred.Count != 0)
            {
                AddCarsToList(carsFiltred);
            }
            else
            {
                MessageBox.Show("Не знайдено необхідного автомобіля");
                this.Close();
            }

        }

        private List<Car> FiltringCarList(EntryList<Car> entryCarList)
        {
            List<Car> cars = null;
            List<Car> carsFiltred = new List<Car>();
            try
            {
                cars = entryCarList();
            }
            catch (FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tШлях до файлу: {ex.FilePath}");
                return null;
            }
            if (carTo.Brand != "" && carTo.Model != "")
            {
                foreach (var car in cars)
                {
                    if (car.GetType() == carTo.GetType() && carTo.Brand == car.Brand && carTo.Model == car.Model)
                    {
                        if (carTo.ProductionYear != 1 && carFrom.ProductionYear != 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear && carFrom.ProductionYear <= car.ProductionYear)
                            {
                                carsFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear != 1)
                        {
                            if (carFrom.ProductionYear <= car.ProductionYear)
                            {
                                carsFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear != 1 && carFrom.ProductionYear == 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear)
                            {
                                carsFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear == 1)
                        {
                            carsFiltred.Add(car);
                        }
                    }
                }
            }
            else if (carTo.Brand != "" && carTo.Model == "")
            {
                foreach (var car in cars)
                {
                    if (car.GetType() == carTo.GetType() && carTo.Brand == car.Brand)
                    {
                        if (carTo.ProductionYear != 1 && carFrom.ProductionYear != 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear && carFrom.ProductionYear <= car.ProductionYear)
                            {
                                carsFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear != 1)
                        {
                            if (carFrom.ProductionYear <= car.ProductionYear)
                            {
                                carsFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear != 1 && carFrom.ProductionYear == 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear)
                            {
                                carsFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear == 1)
                        {
                            carsFiltred.Add(car);
                        }
                    }
                }
            }
            else if (carTo.Brand == "" && carTo.Model == "")
            {
                foreach (var car in cars)
                {
                    if (car.GetType() == carTo.GetType())
                    {
                        if (carTo.ProductionYear != 1 && carFrom.ProductionYear != 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear && carFrom.ProductionYear <= car.ProductionYear)
                            {
                                carsFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear != 1)
                        {
                            if (carFrom.ProductionYear <= car.ProductionYear)
                            {
                                carsFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear != 1 && carFrom.ProductionYear == 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear)
                            {
                                carsFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear == 1)
                        {
                            carsFiltred.Add(car);
                        }
                    }
                }
            }
            return carsFiltred;
        }

        /*private List<T> ReadFromFile<T>()
        {
            List<T> list = new List<T>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Cars.bin", FileMode.OpenOrCreate))
            {
                list = (List<T>)formatter.Deserialize(fs);
            }
            return list;
        }*/

        private void FilterButton_Click(object sender, EventArgs e)
        {
            carsFiltred.Sort();
            CarListView.Items.Clear();
            AddCarsToList(carsFiltred);
        }

        private void CarListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TopBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectButtn_Click(object sender, EventArgs e)
        {
            Car car;
            if (CarListView.SelectedItems.Count == 1)
            {
                ConfirmationForm Form = new ConfirmationForm();
                car = carsFiltred[CarListView.SelectedItems[0].Index];
                Form.SearchCar = car;
                this.Visible = false;
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Перевірте ввід даних");
            }
        }

        private void ExtraInfoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
