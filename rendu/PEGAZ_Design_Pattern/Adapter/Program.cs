using Adapter;

Console.WriteLine(">--------------------------------------------<");
Console.WriteLine("Author: Benoit PEGAZ - ESGI Lyon Master Architecture des Logiciels");
Console.WriteLine("Design Pattern: Adapter\n");

Console.WriteLine("Description: We want to send several types of notifications (notifications by email/smtp, by sms, eventually maybe more). To do this, we use an adapter\n");

Console.WriteLine("Details: We have an interface called INotification.");
Console.WriteLine("Several services allow to send different types of notifications");
Console.WriteLine("Here our two services managing the sending of notifications are 'SMSService' and 'SMTPService' (the code related to the sending has been simplified).");
Console.WriteLine("To adapt the services to the interface, two adapters have been created: 'SMSNotification' and 'EmailNotification'.\n");
Console.WriteLine(">--------------------------------------------<\n");



Console.WriteLine("\n----- \t EmailNotification \t -----");
INotification emailNotification = new EmailNotification();
emailNotification.sendNotification("Benoit", "Hi!");

Console.WriteLine("\n----- \t SMSNotification \t -----");
INotification smsNotification = new SMSNotification();
smsNotification.sendNotification("0606060606", "Hi!");

Console.ReadKey();