using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler Next { protected get; set; }

        public abstract void GiveResponse(float price);

        public float MinimumPrice { get; protected set; }
        public float MaximumPrice { get; protected set; }
    }
}
