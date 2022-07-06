using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SamsungRemote : Remote
    {
        public SamsungRemote(ITelevision television) : base(television) {
            Console.WriteLine($"Samsung remote linked to {television.GetTVType()}");
        }

        public override void SwitchOn()
        {
            television.SwitchOn();
        }
        public override void SwitchOff()
        {
            television.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            television.SetChannel(channelNumber);
        }
    }
}
