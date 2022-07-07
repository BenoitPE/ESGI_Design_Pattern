using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CityDecorator : Decorator
    {
        public CityDecorator(ICountry composant) : base(composant) { }

        protected void printCityInformations()
        {
            Console.WriteLine("Informations about the city");
        }

        public override void printInformations()
        {
            base.printInformations();
            this.printCityInformations();
        }
    }
}
