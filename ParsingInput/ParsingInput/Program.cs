using System;

namespace ParsingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MINUTES_IN_HOUR = 60;
            const double PI = 3.14159;
            const string MESSAGE = "Bueno Dias";

            // concatentation
            Console.WriteLine("There are " + MINUTES_IN_HOUR +
                " minutes in a hour.");

            string aNumber = "42";
            Console.WriteLine(aNumber + aNumber);

            // this is string interpolaration
            Console.WriteLine("There are {0} minutes in a hour.", MINUTES_IN_HOUR);
            
            //int number = 42;
            //Console.WriteLine(number + number);

            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("You entered {0}", number + number);


            Console.WriteLine("Hello World!");
        }
    }
}
