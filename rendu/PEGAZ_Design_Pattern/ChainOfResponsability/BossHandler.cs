using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class BossHandler : Handler
    {
        public BossHandler()
        {
            this.minimumPrice = 2500;
            this.maximumPrice = float.PositiveInfinity;
        }
        public override void giveResponse(float price)
        {
            if (price >= minimumPrice && price < maximumPrice)
                Console.WriteLine($"| {minimumPrice} \t \t \t | {price} \t | Infinity \t \t | Minimum a boss is able to accept");
            else if (next != null)
                next.giveResponse(price);
        }
    }
}
