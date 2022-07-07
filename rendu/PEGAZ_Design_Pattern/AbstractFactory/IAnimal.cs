using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IAnimal
    {
        Feline addFeline(string name);

        Reptile addReptile(string name);

    }
}
