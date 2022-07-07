using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Decorator : ICountry
    {
        protected ICountry composant;

        public Decorator(ICountry composant)
        {
            this.composant = composant;
        }

        public virtual void printInformations()
        {
            composant.printInformations();
        }
    }
}
