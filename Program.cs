using System;

namespace FileOverwriteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.DisplayMenu();
                int choice = Menu.GetUserChoice();

                if (choice == 0)
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }
                else if (choice == 1)
                {
                    string overwriteFilePath = Console.ReadLine();
                    Console.Write("Please provide the path of the ");
                    Console.ForegroundColor = ConsoleColor.Red; // Color for "OFFICIAL"
                    Console.Write("UNOFFICIAL");
                    Console.ResetColor(); // Reset color to default
                    Console.WriteLine(" file: ");
                    string sourceFilePath = Console.ReadLine();
                    FileManager.BackupUnofficialFile(sourceFilePath);
                }
                else if (choice == 2)
                {
                    Console.Write("Please provide the path of the ");
                    Console.ForegroundColor = ConsoleColor.Red; // Color for "OFFICIAL"
                    Console.Write("UNOFFICIAL");
                    Console.ResetColor(); // Reset color to default
                    Console.WriteLine(" file: ");
                    string sourceFilePath = Console.ReadLine();

                    Console.Write("Please provide the path of the ");
                    Console.ForegroundColor = ConsoleColor.Green; // Color for "OFFICIAL"
                    Console.Write("OFFICIAL");
                    Console.ResetColor(); // Reset color to default
                    Console.WriteLine(" file: ");
                    string overwriteFilePath = Console.ReadLine();

                    FileManager.OverwriteFiles(sourceFilePath, overwriteFilePath);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
        }
    }
}
