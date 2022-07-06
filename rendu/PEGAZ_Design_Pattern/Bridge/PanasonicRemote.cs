using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PanasonicRemote : Remote
    {
        public PanasonicRemote(ITelevision television) : base(television) {
            Console.WriteLine($"Panasonic remote linked to {television.GetTVType()}");
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
