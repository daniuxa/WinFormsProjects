using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShowroom
{
    interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Price { get; set; }
        int ProductionYear { get; set; }
    }
    /*
     interface ICompareble
    {
        int CompareTo(object obj);
    }
     */
    interface IClient
    {
        string Name { get; set; }
        string Surname { get; set; }
        string PhoneNumber { get; set; }
        DateTime VisitDate { get; set; }
        Vehicle ViewVehicle { get; set; }
    }

    interface IFilter
    {
        bool Filter(object objFrom, object objTo);
    }
}
