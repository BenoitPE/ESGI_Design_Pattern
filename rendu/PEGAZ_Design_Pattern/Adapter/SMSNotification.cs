using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SMSNotification: INotification
    {
        private SMSService smsService;
        public SMSNotification()
        {
            smsService = new SMSService();
            Console.WriteLine("The 'SMSNotification' adapter that allows to adapt between 'INotification' and 'SMSService' has been created");
        }

        public void sendNotification(string user, string content)
        {
            smsService.send(user, content);
        }


    }
}
