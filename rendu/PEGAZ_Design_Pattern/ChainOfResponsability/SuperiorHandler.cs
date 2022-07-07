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
            this.minimumPrice = 1000;
            this.maximumPrice = 2500;
        }
        public override void giveResponse(float price)
        {
            if (price >= minimumPrice && price < maximumPrice)
                Console.WriteLine($"| {minimumPrice} \t \t \t | {price} \t | {maximumPrice} \t \t | Minimum a superior is able to accept");
            else if (next != null)
                next.giveResponse(price);
        }
    }
}
