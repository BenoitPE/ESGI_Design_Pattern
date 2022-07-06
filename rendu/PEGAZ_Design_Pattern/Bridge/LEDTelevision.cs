using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class LEDTelevision : ITelevision
    {
        public void SwitchOn()
        {
            Console.WriteLine($"{this.GetTVType()}: \t Turning ON");
        }
        public void SwitchOff()
        {
            Console.WriteLine($"{this.GetTVType()}: \t Turning OFF");
        }
        public void SetChannel(int channel)
        {
            Console.WriteLine($"{this.GetTVType()}: \t Setting to channel {channel}");
        }
        public string GetTVType()
        {
            return "LED Television";
        }
    }
}
