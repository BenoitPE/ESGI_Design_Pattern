namespace Common
{
    public static class UI
    {
        public static void printCopyright(string designPattern, string? description = null, string? details = null)
        {
            ConsoleColor consoleColor = ConsoleColor.DarkYellow;
            Console.WriteLine(">--------------------------------------------<");

            Console.Write("Author: ");
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Benoit PEGAZ - ESGI Lyon Master Architecture des Logiciels");
            Console.ResetColor();

            Console.Write("Design Pattern: ");
            Console.ForegroundColor = consoleColor;
            Console.WriteLine($"{designPattern}\n");
            Console.ResetColor();

            Console.Write("Description: ");
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(description);
            Console.ResetColor();

            if(details != null)
            {
                Console.Write("Details: ");
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(details);
                Console.ResetColor();
            }

            Console.WriteLine(">--------------------------------------------<\n");
        }
    }
}