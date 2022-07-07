using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SubordinateHandler : Handler
    {
        public SubordinateHandler()
        {
            this.minimumPrice = 0;
            this.maximumPrice = 1000;
        }
        public override void giveResponse(float price)
        {
            if(price >= minimumPrice && price < maximumPrice)
                Console.WriteLine($"| {minimumPrice} \t \t \t | {price} \t \t | {maximumPrice} \t \t | Subordinate is able to accept");
            else if(next != null)
                next.giveResponse(price);
        }
    }
}
