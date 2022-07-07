using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Cat : Feline
    {
        public Cat(string name) : base(name) { }

        public override void printAnimal()
        {
            Console.WriteLine($"I'm a cat, my name is {Name}");
        }
    }
}
