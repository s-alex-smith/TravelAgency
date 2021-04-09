using System;
namespace TravelAgency
{
    public class ConsoleService
    {
        public ConsoleService()
        {
            Console.WriteLine("Comment tu'tappelles?");
            String name = Console.ReadLine();
            Console.WriteLine($"Bonjour {name}, enchanté");
        }
    }
}
