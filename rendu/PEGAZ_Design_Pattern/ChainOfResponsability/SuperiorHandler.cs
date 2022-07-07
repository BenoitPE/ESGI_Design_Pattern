using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SuperiorHandler : Handler
    {
        public SuperiorHandler()
        {
            this.MinimumPrice = 1000;
            this.MaximumPrice = 2500;
        }
        public override void GiveResponse(float price)
        {
            if (price >= MinimumPrice && price < MaximumPrice)
                Console.WriteLine($"| {MinimumPrice} \t \t \t | {price} \t | {MaximumPrice} \t \t | Minimum a superior is able to accept");
            else if (Next != null)
                Next.GiveResponse(price);
        }
    }
}
