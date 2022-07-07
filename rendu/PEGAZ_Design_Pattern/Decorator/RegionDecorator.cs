using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class RegionDecorator : Decorator
    {
        public RegionDecorator(ICountry composant) : base(composant) { }

        protected void printRegionInformations()
        {
            Console.WriteLine("Informations about the region");
        }

        public override void printInformations()
        {
            base.printInformations();
            this.printRegionInformations();
        }
    }
}
