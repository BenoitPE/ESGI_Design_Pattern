using Adapter;
using Common;

string description = "We want to send several types of notifications (notifications by email/smtp, by sms, eventually maybe more). To do this, we use an adapter\n";
string details = @"
We have an interface called INotification.
Several services allow to send different types of notifications
Here our two services managing the sending of notifications are 'SMSService' and 'SMTPService' (the code related to the sending has been simplified).
To adapt the services to the interface, two adapters have been created: 'SMSNotification' and 'EmailNotification'.";

UI.printCopyright("Adapter", description, details);

Console.WriteLine("\n----- \t EmailNotification \t -----");
INotification emailNotification = new EmailNotification();
emailNotification.sendNotification("Benoit", "Hi!");

Console.WriteLine("\n----- \t SMSNotification \t -----");
INotification smsNotification = new SMSNotification();
smsNotification.sendNotification("0606060606", "Hi!");

Console.ReadKey();