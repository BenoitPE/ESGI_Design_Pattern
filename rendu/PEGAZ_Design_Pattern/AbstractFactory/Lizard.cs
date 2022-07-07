using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Lizard : Reptile
    {
        public Lizard(string name) : base(name) { }

        public override void printAnimal()
        {
            Console.WriteLine($"I'm a lizard, my name is {Name}");
        }
    }
}
