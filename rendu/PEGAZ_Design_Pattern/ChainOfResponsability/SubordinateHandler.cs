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
            this.MinimumPrice = 0;
            this.MaximumPrice = 1000;
        }
        public override void GiveResponse(float price)
        {
            if(price >= MinimumPrice && price < MaximumPrice)
                Console.WriteLine($"| {MinimumPrice} \t \t \t | {price} \t \t | {MaximumPrice} \t \t | Subordinate is able to accept");
            else if(Next != null)
                Next.GiveResponse(price);
        }
    }
}
