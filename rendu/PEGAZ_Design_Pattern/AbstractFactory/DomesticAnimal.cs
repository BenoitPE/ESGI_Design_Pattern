using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class DomesticAnimal : IAnimal
    {
        public Feline addFeline(string name)
        {
            return new Cat(name);
        }

        public Reptile addReptile(string name)
        {
            return new Lizard(name);
        }
    }
}
