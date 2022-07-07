using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Tiger : Feline
    {
        public Tiger(string name) : base(name) { }

        public override void printAnimal()
        {
            Console.WriteLine($"I'm a tiger, my name is {Name}");
        }
    }
}
