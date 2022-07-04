using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class ElectricAutomobile : Automobile
    {
        public ElectricAutomobile(string model, string color, int power, double space) : base(model, color, power, space)
        {
        }

        public override void showCarac()
        {
            Console.WriteLine("Electric car: ");
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("Space: " + space);
        }
    }
}
