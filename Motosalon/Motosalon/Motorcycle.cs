﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon
{
    [Serializable]
    class Motorcycle : Mototransport
    {
        private string typeMotorcycle;
        public string TypeMotorcycle
        {
            get
            {
                return typeMotorcycle;
            }
            set
            {
                WorkingWithFiles<List<string>> workingWithFiles = new WorkingWithFiles<List<string>>();
                if (value == "")
                {
                    typeMotorcycle = "";
                    return;
                }
                   
                List<string> Typemotorcycle;
                Typemotorcycle = workingWithFiles.ReadingFromFile("Typemotorcycle.bin");
                if (Typemotorcycle == null)
                    return;

                if (Typemotorcycle.Contains(value) == true)
                {
                    typeMotorcycle = value;
                }
                else
                {
                    throw new TypeMotorcycleException("Неправильно введено тип мотоцикла", value);
                }
            }
        }
        public Motorcycle(string Brand, string Model, int Price, int Volume, string TypeMotorcycle) : base(Brand, Model, Price, Volume)
        {
            this.TypeMotorcycle = TypeMotorcycle;
        }
    }
}
