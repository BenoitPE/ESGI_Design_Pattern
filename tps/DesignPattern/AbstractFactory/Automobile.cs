using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public abstract class Automobile
    {
        protected string model;
        protected string color;
        protected int power;
        protected double space;

        public Automobile(string model, string color, int power, double space)
        {
            this.model = model;
            this.color = color;
            this.power = power;
            this.space = space;
        }

        public abstract void showCarac();
    }
}
