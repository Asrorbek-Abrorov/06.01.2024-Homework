using System;
using System.IO;
using Spectre.Console;
class Program
{
    static void Main(string[] args)
    {
        string originalDirectory;

        originalDirectory = AnsiConsole.Ask<string>("Write the name of the directory that you want to change : ");
        
        
        
        string originalDirectoryPath = $"../../../../Files_1_homework/{originalDirectory}";
        
        if (!Directory.Exists(originalDirectoryPath))
        {
            Console.WriteLine("Directory does not exist.");
            return;
        }
        
        string newDirectoryName;

        newDirectoryName = AnsiConsole.Ask<string>("Enter the new name for the directory:");
        
        Directory.CreateDirectory($"../../../../Files_1_homework/{newDirectoryName}");
        
        Directory.Delete($"../../../../Files_1_homework/{originalDirectory}");

        Console.WriteLine("Changed successfully!");
    }
}