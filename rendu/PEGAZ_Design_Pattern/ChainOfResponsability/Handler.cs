using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler next { protected get; set; }

        public abstract void giveResponse(float price);

        public float minimumPrice { get; protected set; }
        public float maximumPrice { get; protected set; }
    }

}
