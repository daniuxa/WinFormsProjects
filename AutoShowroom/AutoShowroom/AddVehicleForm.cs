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
    public partial class AddVehicleForm : Form
    {
        private List<Vehicle> vehicles;
        private Dictionary<string, List<string>> brandModelCar;
        private Dictionary<string, List<string>> brandModelMoto;
        private List<string> TypeBodyCar;
        private List<string> TypeMoto;
        private FileClass<List<string>> fileListStr;
        private FileClass<Dictionary<string, List<string>>> fileClassDictionary;
        private FileClass<List<Vehicle>> fileListVehicle;
        public AddVehicleForm(ref List<Vehicle> vehicles)
        {
            InitializeComponent();
            this.vehicles = vehicles;
        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            fileListStr = new FileClass<List<string>>();
            fileClassDictionary = new FileClass<Dictionary<string, List<string>>>();
            fileListVehicle = new FileClass<List<Vehicle>>();
            ExtraComboBox.Visible = false;
            ExtraFieldText.Visible = false;
            for (int i = DateTime.Now.Year; i > 1900; i--)
            {
                ProdYearComboBox.Items.Add(i);
            }
            /*Dictionary<string, List<string>> brandModel = new Dictionary<string, List<string>>();
            brandModel.Add("Yamaha", new List<string>() { "TZR", "FJR", "XV" });
            brandModel.Add("Ducati", new List<string>() { "SuperSport", "Superleggera", "Panigale" });
            brandModel.Add("Honda", new List<string>() { "RC", "CTX", "CRF" });
            brandModel.Add("Kawasaki", new List<string>() { "Ninja ZX", "Versys", "KX" });
            brandModel.Add("BMW", new List<string>() { "M Series", "R 18", "HP2" });
            brandModel.Add("Suzuki", new List<string>() { "GSX", "RM-Z", "Boulevard" });

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\BrandModelMoto.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, brandModel);
            }*/
            /*            List<string> TypeBody = new List<string>();
                        TypeBody.Add("Седан");
                        TypeBody.Add("Хетчбек");
                        TypeBody.Add("Кросовер");
                        TypeBody.Add("Універсал");
                        List<string> TypeMoto = new List<string>();
                        TypeMoto.Add("Спорт");
                        TypeMoto.Add("Туризм");
                        TypeMoto.Add("Кросові");*/

            try
            {
                brandModelMoto = fileClassDictionary.ReadingFromFile(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\BrandModelMoto.bin");
                brandModelCar = fileClassDictionary.ReadingFromFile(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\BrandModelCar.bin");
                TypeBodyCar = fileListStr.ReadingFromFile(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\TypeBodyCar.bin");
                TypeMoto = fileListStr.ReadingFromFile(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\TypeMoto.bin");
            }
            catch (FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                return;
            }            
        }

        private void TypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (TypeComboBox.Text == "Автомобіль")
            {
                BrandComboBox.Items.Clear();
                ModelComboBox.Items.Clear();
                BrandComboBox.Text = "";
                ModelComboBox.Text = "";
                foreach(var brandModel in brandModelCar)
                {
                    BrandComboBox.Items.Add(brandModel.Key);
                }
                ExtraFieldText.Text = "Тип кузова";
                ExtraComboBox.Items.Clear();
                for (int i = 0; i < TypeBodyCar.Count; i++)
                {
                    ExtraComboBox.Items.Add(TypeBodyCar[i]);
                }
                ExtraFieldText.Visible = true;
                ExtraComboBox.Visible = true;
            }
            else if (TypeComboBox.Text == "Мотоцикл")
            {
                BrandComboBox.Items.Clear();
                ModelComboBox.Items.Clear();
                BrandComboBox.Text = "";
                ModelComboBox.Text = "";
                foreach (var brandModel in brandModelMoto)
                {
                    BrandComboBox.Items.Add(brandModel.Key);
                }
                ExtraFieldText.Text = "Тип мотоцикла";
                ExtraComboBox.Items.Clear();
                for (int i = 0; i < TypeMoto.Count; i++)
                {
                    ExtraComboBox.Items.Add(TypeMoto[i]);
                }
                ExtraFieldText.Visible = true;
                ExtraComboBox.Visible = true;
            }
        }

        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelComboBox.Items.Clear();
            ModelComboBox.Text = "";
            if (TypeComboBox.Text == "Автомобіль")
            {
                foreach (var brandModel in brandModelCar)
                {
                    if(BrandComboBox.Text == brandModel.Key)
                    {
                        for (int i = 0; i < brandModel.Value.Count; i++)
                        {
                            ModelComboBox.Items.Add(brandModel.Value[i]);
                        }
                        break;
                    }
                }
               
            }
            else if (TypeComboBox.SelectedIndex == 1)
            {
                foreach (var brandModel in brandModelMoto)
                {
                    if (BrandComboBox.Text == brandModel.Key)
                    {
                        for (int i = 0; i < brandModel.Value.Count; i++)
                        {
                            ModelComboBox.Items.Add(brandModel.Value[i]);
                        }
                        break;
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TypeComboBox.Text != "" && BrandComboBox.Text != "" && ModelComboBox.Text != "" && ProdYearComboBox.Text!= "" && PriceTextBox.Text != "" && ExtraComboBox.Text != "")
            {
                if (Int32.TryParse(PriceTextBox.Text, out int Price) == false)
                {
                    MessageBox.Show("Перевірте правильність вводу ціни");
                }
                if (TypeComboBox.SelectedIndex == 0)
                {
                    Car car = null;
                    try
                    {
                        car = new Car(BrandComboBox.Text, ModelComboBox.Text, Int32.Parse(ProdYearComboBox.Text), Price, ExtraComboBox.Text);
                    }
                    catch(BodyTypeException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (ProductionYearException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (PriceException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (FileException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                        return;
                    }

                    vehicles.Add(car);
                }
                else
                {
                    Moto moto = null;
                    try
                    {
                        moto = new Moto(BrandComboBox.Text, ModelComboBox.Text, Int32.Parse(ProdYearComboBox.Text), Price, ExtraComboBox.Text);
                    }
                    catch (TypeMotoException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (ProductionYearException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (PriceException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (FileException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                        return;
                    }
                    vehicles.Add(moto);
                }
                try
                {
                    fileListVehicle.WritingToFile(vehicles, @"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\Vehicles.bin");
                }
                catch (FileException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.FilePath}");
                    return;
                }
                MessageBox.Show("Успішно додано");
                this.Close();
            }
            else
            {
                MessageBox.Show("Перевірте правильність вводу полів");
                return;
            }
        }
    }
}
