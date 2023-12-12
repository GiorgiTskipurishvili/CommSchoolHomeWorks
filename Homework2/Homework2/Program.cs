using System;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Giorgi Tskipurishvili");

            Console.Write("Enter Something: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Output: " + userInput);


            Console.WriteLine("I love C#");

            Console.ReadKey();
        }
    }
}
