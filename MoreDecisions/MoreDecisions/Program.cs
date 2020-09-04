using System;

namespace MoreDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AGE_TO_RENT_VEHICLE = 25;
            const int MIN_DRIVING_AGE = 16;

            Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //int age = 0;
            if(int.TryParse(Console.ReadLine(), out int age))
            {
                Console.Write("Do you have a license? (y/n): ");
                string hasLicense = Console.ReadLine();

                // What does an if statement requires to have?
                // boolean expression
                if (age >= MIN_DRIVING_AGE && (hasLicense == "y" || hasLicense == "yes"))
                {
                    Console.WriteLine("You're permitted to drive.");
                    //Console.WriteLine("Due to your age, you do not need to pay for the surcharge");
                }
                else
                {
                    Console.WriteLine("You're NOT permitted to drive.");
                }
            }
            else
            {
                Console.WriteLine("You entered an invalid input.");
            }

            

        }
    }
}
