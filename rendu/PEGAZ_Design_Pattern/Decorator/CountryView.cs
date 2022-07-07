using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CountryView : ICountry
    {
        public void printInformations()
        {
            Console.WriteLine("Informations about the country");
        }
    }
}
