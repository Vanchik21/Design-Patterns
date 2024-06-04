using System;
using System.IO;
using FlyweightLib;
using CompositeLib;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathForFlyweight = @"C:\Users\ivank\OneDrive\Документы\Design-Patterns\lab3\files\task6.txt";

            try
            {
                Console.WriteLine("Without Flyweight");
                ReadFiles.ReadFilesWithoutFlyweight(pathForFlyweight);
                Console.WriteLine("----------------------------");
                Console.WriteLine("With Flyweight");
                ReadFiles.ReadFilesWithFlyweight(pathForFlyweight);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred while accessing the file: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}