using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AutoShowroom
{
    /*Класс мотоцикла, наследуется от транспортного средства*/
    [Serializable]
    class Moto : Vehicle
    {
        private string typeMoto; //Тип мотоцикла
        public string TypeMoto 
        {
            get
            {
                return typeMoto;
            }
            set
            {
                FileClass<List<string>> fileListString = new FileClass<List<string>>();
                List<string> typeMotoList = null;
                typeMotoList = fileListString.ReadingFromFile(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\TypeMoto.bin");
                /*BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\TypeMoto.bin", FileMode.OpenOrCreate))
                {
                    typeMotoList = (List<string>)formatter.Deserialize(fs);
                }*/
                if (typeMotoList.Contains(value) == true)
                {
                    typeMoto = value;
                }
                else
                {
                    throw new TypeMotoException("Неправильно введено тип мотоциклу", value);
                }
            }
        }
        public Moto(string Brand, string Model, int ProductionYear, int Price, string TypeMoto) : base(Brand, Model, ProductionYear, Price)
        {
            this.TypeMoto = TypeMoto;
        }
        public Moto(string Brand, string Model, int ProductionYear) : base(Brand, Model, ProductionYear)
        {
        }
    }
}
