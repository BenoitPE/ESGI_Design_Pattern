using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SMTPService
    {
        public void send(string email, string content)
        {
            Console.WriteLine($"An email was sent to {email} with content '{content}'!");
        }
    }
}
