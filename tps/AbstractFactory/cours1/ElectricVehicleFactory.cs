using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours1
{
    public class ElectricVehicleFactory : IVehicleFactory
    {

        public Automobile CreateAutomobile(string model, string color, int power, double space)
        {
            return new ElectricAutomobile(model, color, power, space);
        }
    }
}
