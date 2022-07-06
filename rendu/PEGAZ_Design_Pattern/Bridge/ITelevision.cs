using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ITelevision
    {
        public void SwitchOn();
        public void SwitchOff();
        public void SetChannel(int channel);
        public string GetTVType();
    }
}
