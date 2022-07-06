using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EmailNotification : INotification
    {
        private SMTPService smtpService;
        public EmailNotification()
        {
            smtpService = new SMTPService();
            Console.WriteLine("The 'EmailNotification' adapter that allows to adapt between 'INotification' and 'SMTPService' has been created");
        }

        public void sendNotification(string user, string content)
        {
            smtpService.send(user, content);
        }
    }
}
