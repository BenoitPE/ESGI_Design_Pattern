using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class KomodoDragon : Reptile
    {
        public KomodoDragon(string name) : base(name) { }

        public override void printAnimal()
        {
            Console.WriteLine($"I'm a komodo dragon, my name is {Name}");
        }
    }
}
