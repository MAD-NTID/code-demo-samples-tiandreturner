using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("10" == 10);

            //const int AGE_TO_RENT_VEHICLE = 25;

            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= AGE_TO_RENT_VEHICLE)
            //{
            //    Console.WriteLine("Due to your age, you do not need to pay for the surcharge");
            //    Environment.Exit(0); // you can use this to quit the program.
            //}

            //Console.WriteLine("Due to your age, you will need to pay for the surcharge");

            const string SECRET_PASSWORD = "MADstudentsAreAWESOME";
            Console.WriteLine("Guess the password: ");
            string password = Console.ReadLine();
            if(password == SECRET_PASSWORD)
            {
                Console.WriteLine("You guessed correct!");
                Environment.Exit(0);
            }

            Console.WriteLine("Sorry, it is not correct!");
        }
    }
}
