using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WildAnimal : IAnimal
    {
        public Feline addFeline(string name)
        {
            return new Tiger(name);
        }

        public Reptile addReptile(string name)
        {
            return new KomodoDragon(name);
        }
    }
}
