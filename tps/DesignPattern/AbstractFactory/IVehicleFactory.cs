using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public interface IVehicleFactory
    {
        Automobile CreateAutomobile(string model, string color, int power, double space);
    }
}
