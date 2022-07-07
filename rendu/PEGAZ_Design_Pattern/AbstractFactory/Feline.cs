using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Feline
    {
        public string Name { get; set; }
        public Feline(string name)
        {
            this.Name = name;
        }

        public abstract void printAnimal();
    }
}
