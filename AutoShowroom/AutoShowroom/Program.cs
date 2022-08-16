using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShowroom
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClientForm());
        }
    }
}
