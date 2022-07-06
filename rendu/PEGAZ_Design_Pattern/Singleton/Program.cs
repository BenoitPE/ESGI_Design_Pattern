using Singleton;

Console.WriteLine(">--------------------------------------------<");
Console.WriteLine("Author: Benoit PEGAZ - ESGI Lyon Master Architecture des Logiciels");
Console.WriteLine("Design Pattern: Singleton\n");
Console.WriteLine("Description: We are making a shared schedule. An user can add an event in the shared schedule and all users can see it. To do this, we use a Singleton.");
Console.WriteLine(">--------------------------------------------<\n");

User user1 = new User("Benoit");
User user2 = new User("Margaux");

user1.AddToSchedule(new Event($"Event created by {user1.Name}", new DateTime(2022, 06, 07)));

user1.SeeSchedule();
user2.SeeSchedule();

Console.WriteLine($"We can see that {user2.Name} can see the event added by {user1.Name}.");
Console.WriteLine($"Let's now try the reverse, to check that {user1.Name} can see the event created by {user2.Name}\n");

user2.AddToSchedule(new Event($"Event created by {user2.Name}", new DateTime(2022, 06, 08)));

user1.SeeSchedule();
user2.SeeSchedule();

Console.WriteLine("We can see that users can see an event added by another user.\nThe singleton is therefore functional");

Console.ReadKey();