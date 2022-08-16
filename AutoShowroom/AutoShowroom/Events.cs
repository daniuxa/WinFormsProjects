using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShowroom
{
    public class BoughtVehicleEventArg : EventArgs
    {
        public Vehicle vehicle { get; }
        public DateTime BoughtTime { get; }
        public BoughtVehicleEventArg(Vehicle vehicle, DateTime BoughtTime)
        {
            this.vehicle = vehicle;
            this.BoughtTime = BoughtTime;
        }
    }
}
