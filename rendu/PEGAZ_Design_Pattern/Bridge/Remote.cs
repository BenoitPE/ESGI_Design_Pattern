using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Remote
    {
        protected ITelevision television;

        public Remote(ITelevision television)
        {
            this.television = television;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channel);
    }
}
