using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dotnet RPG");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}
