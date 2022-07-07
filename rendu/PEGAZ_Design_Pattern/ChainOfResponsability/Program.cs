using ChainOfResponsibility;

Console.WriteLine(">--------------------------------------------<");
Console.Write("Author: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Benoit PEGAZ - ESGI Lyon Master Architecture des Logiciels");
Console.ResetColor();
Console.Write("Design Pattern: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Chain of Responsability\n");
Console.ResetColor(); 

Console.Write("Description: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("We have a company with a 3 tier hierarchy: Boss>Superior>Subordinate");
Console.WriteLine("This company needs to validate orders and the validator depends on the price.\n");
Console.ResetColor();


Console.WriteLine("Details:");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("If the price < 1000, a subordinate can accept it without superior permission");
Console.WriteLine("If the price >= 1000 and price < 2500, minimum a superior can accept it without boss permission");
Console.WriteLine("If the price >= 2500, only the boss can accept it");
Console.ResetColor();
Console.WriteLine(">--------------------------------------------<\n");
string tableSeparator = "----------------------------------------------------------------------------------------------------------";

Handler subordinate = new SubordinateHandler();
Handler superior = new SuperiorHandler();
Handler boss = new BossHandler();

subordinate.next = superior;
superior.next = boss;

int[] orderPrices = { 500, 1800, 5000};

Console.WriteLine(tableSeparator);
Console.WriteLine("| Min price allowed \t | Order price \t | Max price allowed \t | Details \t \t \t \t |");
Console.WriteLine(tableSeparator);
foreach (int price in orderPrices)
{
    subordinate.giveResponse(price);
}
Console.WriteLine(tableSeparator);

Console.WriteLine("\nIt can be seen that if the price of the order is higher than the maximum allowed price, permission is requested from the superior.");

Console.ReadKey();