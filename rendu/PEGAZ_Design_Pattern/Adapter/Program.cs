using Adapter;

Console.WriteLine(">--------------------------------------------<");
Console.WriteLine("Author: Benoit PEGAZ - ESGI Lyon Master Architecture des Logiciels");
Console.WriteLine("Design Pattern: Adapter\n");
Console.WriteLine("Description: We want to send several types of notifications (notifications by email/smtp, by sms, eventually maybe more).");
Console.WriteLine(">--------------------------------------------<\n");

INotification emailNotification = new EmailNotification();
emailNotification.sendNotification("Benoit", "Hi!");

INotification smsNotification = new SMSNotification();
smsNotification.sendNotification("0606060606", "Hi!");

Console.ReadKey();