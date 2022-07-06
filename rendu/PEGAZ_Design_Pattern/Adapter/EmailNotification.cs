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
        }

        public void sendNotification(string user, string content)
        {
            smtpService.send(user, content);
        }
    }
}
