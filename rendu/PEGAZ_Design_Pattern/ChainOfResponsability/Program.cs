using ChainOfResponsibility;
using Common;

string description = @"
We have a company with a 3 tier hierarchy: Boss>Superior>Subordinate
This company needs to validate orders and the validator depends on the price.
";
string details = @"
If the price < 1000, a subordinate can accept it without superior permission
If the price >= 1000 and price < 2500, minimum a superior can accept it without boss permission
If the price >= 2500, only the boss can accept it
";
string tableSeparator = "----------------------------------------------------------------------------------------------------------";

UI.printCopyright("Chain of Responsibility", description, details);

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