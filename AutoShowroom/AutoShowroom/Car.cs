using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AutoShowroom
{
    /*Класс автомобыля, наследуется от транспортного средства*/
    [Serializable]
    class Car : Vehicle
    {
        private string bodyType; //Тип кузова
        public string BodyType 
        {
            get
            {
                return bodyType;
            }
            set 
            {
                List<string> typeBody = null;
                FileClass<List<string>> fileListString = new FileClass<List<string>>();

                typeBody = fileListString.ReadingFromFile(@"C:\Users\saliv\source\repos\AutoShowroom\AutoShowroom\Files\TypeBodyCar.bin");
                
                if (typeBody.Contains(value) == true)
                {
                    bodyType = value;
                }
                else
                {
                    throw new BodyTypeException("Неправильно введно тип кузова автомобіля", value);
                }
            } 
        }

        public Car(string Brand, string Model, int ProductionYear, int Price, string BodyType) : base(Brand, Model, ProductionYear, Price)
        {
            this.BodyType = BodyType;
        }
        public Car(string Brand, string Model, int ProductionYear) : base(Brand, Model, ProductionYear)
        {
        }
    }
}
