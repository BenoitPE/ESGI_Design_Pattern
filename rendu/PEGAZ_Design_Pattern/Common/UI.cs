namespace Common
{
    public static class UI
    {
        public static void printCopyright(string designPattern, string? description = null, string? details = null)
        {
            Console.WriteLine(">--------------------------------------------<");

            Console.Write("Author: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Benoit PEGAZ - ESGI Lyon Master Architecture des Logiciels");
            Console.ResetColor();

            Console.Write("Design Pattern: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{designPattern}\n");
            Console.ResetColor();

            Console.Write("Description: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(description);
            Console.ResetColor();

            if(details != null)
            {
                Console.Write("Details: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(details);
                Console.ResetColor();
            }

            Console.WriteLine(">--------------------------------------------<");
        }
    }
}