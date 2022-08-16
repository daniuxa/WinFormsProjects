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
    public partial class ClientForm : Form
    {
        private Dictionary<string, List<string>> brandModelCar;
        private Dictionary<string, List<string>> brandModelMoto;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Меняем список брендов 
        private void TypeVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brand.Items.Clear();
            Model.Items.Clear();
            Brand.Text = "";
            Model.Text = "";
            if (TypeVehicle.Text == "Автомобіль")
            {
                foreach (var brandModel in brandModelCar)
                {
                    Brand.Items.Add(brandModel.Key);
                }
            }
            else if (TypeVehicle.Text == "Мотоцикл")
            {
                foreach (var brandModel in brandModelMoto)
                {
                    Brand.Items.Add(brandModel.Key);
                }
            }
        }

        private void Model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Меняем список моделей 
        private void Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Items.Clear();
            Model.Text = "";
            if (TypeVehicle.Text == "Автомобіль")
            {
                foreach (var brandModel in brandModelCar)
                {
                    if (Brand.Text == brandModel.Key)
                    {
                        for (int i = 0; i < brandModel.Value.Count; i++)
                        {
                            Model.Items.Add(brandModel.Value[i]);
                        }
                        break;
                    }
                }
            }
            else if (TypeVehicle.Text == "Мотоцикл")
            {
                foreach (var brandModel in brandModelCar)
                {
                    if (Brand.Text == brandModel.Key)
                    {
                        for (int i = 0; i < brandModel.Value.Count; i++)
                        {
                            Model.Items.Add(brandModel.Value[i]);
                        }
                        break;
                    }
                }
            }
        }

        //Во время загрузкти форму, заполняем комбобоксы с годами
        private void ClientForm_Load(object sender, EventArgs e)
        {
            /*List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Car("Audi", "A3", 2015, 18000, "Седан"),
                new Car("Audi", "A6", 2005, 8500, "Седан"),
                new Car("Audi", "Q5", 2013, 16000, "Кросовер"),
                new Car("Toyota", "Corolla", 2018, 14450, "Седан"),
                new Car("Toyota", "Camry", 2018, 30000, "Седан"),
                new Car("Toyota", "RAV 4", 2016, 23000, "Кросовер"),
                new Car("BMW", "5 Series", 2015, 17000, "Седан"),
                new Car("BMW", "1 Series", 2015, 25000, "Хетчбек"),
                new Car("BMW", "X5", 2002, 8000, "Кросовер"),
                new Car("Volkswagen", "Polo", 2003, 5000, "Хетчбек"),
                new Car("Volkswagen", "Passat", 2006, 8500,"Седан"),
                new Car("Volkswagen", "Touareg", 2009, 17000,"Кросовер"),
                new Car("Ford", "Focus", 2017, 9900,"Хетчбек"),
                new Car("Ford", "Kuga", 2011, 13500,"Кросовер"),
                new Car("Ford", "Mondeo", 2008, 6500, "Седан"),
                new Car("Skoda", "Octavia", 2009, 8000, "Седан"),
                new Car("Skoda", "Fabia", 2006, 5000, "Хетчбек"),
                new Car("Skoda", "Yeti", 2011, 9000, "Кросовер"),
                new Moto("Yamaha", "TZR", 2008, 1300, "Спорт"),
                new Moto("Ducati", "Panigale", 2021, 5300, "Спорт"),
                new Moto("BMW", "HP2", 2006, 10000, "Кросові")
            };*/
            YearFrom.Items.Add("-");
            YearTo.Items.Add("-");
            for (int i = DateTime.Now.Year; i > 1900; i--)
            {
                YearFrom.Items.Add(i);
                YearTo.Items.Add(i);
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\BrandModelMoto.bin", FileMode.OpenOrCreate))
            {
                brandModelMoto = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
            }
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\BrandModelCar.bin", FileMode.OpenOrCreate))
            {
                brandModelCar = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int YearTo = 1900;    //Начальное значение года 
            int YearFrom = 1900;

            if (TypeVehicle.Text == "") //Если у нас вообще ничего не заполнено
            {
                MessageBox.Show("Перевірте введені вами значення");
                return;
            }
            //Если оба комбобокса с годами пустые
            if ((this.YearTo.Text.ToString() == "" || this.YearTo.Text.ToString() == "-") && (this.YearFrom.Text.ToString() == "" || this.YearFrom.Text.ToString() == "-"))
            {

            }
            //Если комбобокс с годом "от" заполнен, а "до" пустой
            else if ((this.YearTo.Text.ToString() == "" || this.YearTo.Text.ToString() == "-") && (this.YearFrom.Text.ToString() != "" && this.YearFrom.Text.ToString() != "-"))
            {
                try
                {
                    YearFrom = Int32.Parse(this.YearFrom.Text.ToString());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Перевірте введений вами рік");
                    return;
                }
            }
            //Если комбобокс с годом "от" пустой, а "до" заполнен
            else if ((this.YearTo.Text.ToString() != "" && this.YearTo.Text.ToString() != "-") && (this.YearFrom.Text.ToString() == "" || this.YearFrom.Text.ToString() == "-"))
            {
                try
                {

                    YearTo = Int32.Parse(this.YearTo.Text.ToString());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Перевірте введений вами рік");
                    return;
                }
            }
            //Если оба комбобокса с годами заполнен
            else if ((this.YearTo.Text.ToString() != "" && this.YearTo.Text.ToString() != "-") && (this.YearFrom.Text.ToString() != "" && this.YearFrom.Text.ToString() != "-"))
            {
                try
                {   
                    YearTo = Int32.Parse(this.YearTo.Text.ToString());
                    YearFrom = Int32.Parse(this.YearFrom.Text.ToString());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Перевірте введений вами рік");
                    return;
                }
            }
            //Если год "от" больше чем "до" и ячейки не пустые
            if (YearFrom > YearTo && YearFrom != 1900 && YearTo != 1900)
            {
                MessageBox.Show("Перевірте введний вами рік");
            }
            else
            {
                Car SearchCarFrom = null;
                Car SearchCarTo = null;
                if (TypeVehicle.SelectedIndex == 0)
                {
                    try
                    {
                        SearchCarFrom = new Car(Brand.Text, Model.Text, YearFrom);
                        SearchCarTo = new Car(Brand.Text, Model.Text, YearTo);
                    }
                    catch (ProductionYearException ex)
                    {
                        MessageBox.Show($"{ex.Message}\tЗначення:{ex.Value}");
                        return;
                    }

                    ListForm form = new ListForm(SearchCarFrom, SearchCarTo);
                    form.ShowDialog();
                    //MessageBox.Show($"Пошук по автомобілю\nБренд:{SearchCarFrom.Brand}\nМодель:{SearchCarFrom.Model}\nРік від:{SearchCarFrom.ProductionYear}\tдо:{SearchCarTo.ProductionYear}");
                }
                else
                {
                    Moto SearchMotoFrom = null;
                    Moto SearchMotoTo = null;
                    try
                    {
                        SearchMotoFrom = new Moto(Brand.Text, Model.Text, YearFrom);
                        SearchMotoTo = new Moto(Brand.Text, Model.Text, YearTo);
                    }
                    catch (ProductionYearException ex)
                    {
                        MessageBox.Show($"{ex.Message}\tЗначення:{ex.Value}");
                        return;
                    }
                    //MessageBox.Show($"Пошук по мотоциклу\nБренд:{SearchMotoFrom.Brand}\nМодель:{SearchMotoFrom.Model}\nРік від:{SearchMotoFrom.ProductionYear}\tдо:{SearchMotoTo.ProductionYear}");
                    ListForm form = new ListForm(SearchMotoFrom, SearchMotoTo);
                    form.ShowDialog();
                }
            }
        }

        //Открываем окно введения пароля
        private void AdminLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password NewForm = new Password();
            NewForm.ShowDialog();
        }
    }
}
