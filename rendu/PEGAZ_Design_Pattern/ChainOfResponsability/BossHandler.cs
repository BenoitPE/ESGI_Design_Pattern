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
            this.MinimumPrice = 2500;
            this.MaximumPrice = float.PositiveInfinity;
        }
        public override void GiveResponse(float price)
        {
            if (price >= MinimumPrice && price < MaximumPrice)
                Console.WriteLine($"| {MinimumPrice} \t \t \t | {price} \t | Infinity \t \t | Minimum a boss is able to accept");
            else if (Next != null)
                Next.GiveResponse(price);
        }
    }
}
