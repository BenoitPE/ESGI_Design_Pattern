using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DepartmentDecorator : Decorator
    {
        public DepartmentDecorator(ICountry composant) : base(composant) { }

        protected void printDepartementInformations()
        {
            Console.WriteLine("Informations about the department");
        }

        public override void printInformations()
        {
            base.printInformations();
            this.printDepartementInformations();
        }
    }
}
