using System;

namespace FileOverwriteApp
{
    public static class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Select an action:");
            Console.Write("1. Backup ");
            Console.ForegroundColor = ConsoleColor.Red; // Color for "OFFICIAL"
            Console.Write("UNOFFICIAL");
            Console.ResetColor(); // Reset color to default
            Console.WriteLine(" save file");
            Console.WriteLine("2. Overwrite files");
            // Add more options as needed
            Console.WriteLine("0. Exit");
        }

        public static int GetUserChoice()
        {
            Console.Write("Enter your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return choice;
        }
    }
}
