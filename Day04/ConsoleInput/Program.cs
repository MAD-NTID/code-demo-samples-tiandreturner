using System;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            //string name = "Professor Turner";
            string name = Console.ReadLine();

            Console.Write("Enter your favorite number: ");
            string favoriteNumber = Console.ReadLine();

            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your favorite number is {0}", favoriteNumber);
        }
    }
}
