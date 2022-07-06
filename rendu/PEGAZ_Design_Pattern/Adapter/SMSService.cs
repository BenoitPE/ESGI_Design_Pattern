using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SMSService
    {
        public void send(string phonenumber, string content)
        {
            Console.WriteLine($"A text message (sms) was sent to {phonenumber} with content '{content}'!");
        }
    }
}
