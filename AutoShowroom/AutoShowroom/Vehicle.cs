using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShowroom
{
    /*Отцовский абстрактный класс(потому что нам не нужно будет создавать обьект типа Vehicle), которые реализует в себе два интерфейса:
     *IComparable, IVehicle */
    [Serializable]
    public abstract class Vehicle : IComparable, IVehicle, IFilter
    {
        public string Brand { get; set; } //Бренд 
        public string Model { get; set; } //Модель 
        protected int price;              //Цена
        public int Price 
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new PriceException("Неправильно введена ціна", value);
                }
            }
        }
        private int productionYear; //Год производства
        public int ProductionYear
        {
            get
            {
                return productionYear;
            }
            set
            {
                if (DateTime.Now.Year >= value && value >= 1900)
                {
                    productionYear = value;
                }
                else
                {
                    throw new ProductionYearException("Неправильно введен рік випуску", value);
                }
            }
        }
        public Vehicle(string Brand, string Model, int ProductionYear, int Price)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.ProductionYear = ProductionYear;
            this.Price = Price;
        }
        public Vehicle(string Brand, string Model, int ProductionYear)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.ProductionYear = ProductionYear;
        }

        //Метод интерфейса IComparable, который используется для сравнения по цене транспортного средства
        public int CompareTo(object obj)
        {
            Vehicle p = obj as Vehicle;
            if (p != null)
                return price.CompareTo(p.Price);
            else
                throw new Exception("Неможливо порівняти два об'єкта");
        }

        public bool Filter(object objFrom, object objTo)
        {
            Vehicle vehicleFrom = objFrom as Vehicle;
            Vehicle vehicleTo = objTo as Vehicle;
            if (vehicleFrom == null || vehicleTo == null)
            {
                return false;
            } 
            
            if (this.GetType() != vehicleTo.GetType())
            {
                return false;
            }
            if (vehicleTo.Brand != "" && vehicleTo.Brand != this.Brand)
            {
                return false;
            }
            if (vehicleTo.Model != "" && vehicleTo.Model != this.Model)
            {
                return false;
            }
            if (vehicleTo.ProductionYear != 1900 && vehicleFrom.ProductionYear != 1900 && (vehicleTo.ProductionYear < this.ProductionYear || vehicleFrom.ProductionYear > this.ProductionYear))
            {
                return false;
            }
            if (vehicleTo.ProductionYear != 1900 && vehicleFrom.ProductionYear == 1900 && vehicleTo.ProductionYear < this.ProductionYear)
            {
                return false;
            }
            if (vehicleTo.ProductionYear == 1900 && vehicleFrom.ProductionYear != 1900 && vehicleFrom.ProductionYear > this.ProductionYear)
            {
                return false;
            }
            return true;
        }
    }
    
    //List<Vehicle> Vehicles = new List<Vehicle>();
    //Vehicles.Sort();
}
