using System;

namespace MoreMoreDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Pick a number from 1 to 10: ");
            //int number ; //int.Parse(Console.ReadLine());


            //// how to write TryParse in code?
            //if(int.TryParse(Console.ReadLine(), out number))
            //{
            //    // if statement with logical operators
            //     if(number >= 1 && number <= 10)
            //    {
            //        Console.WriteLine("You picked {0}", number);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Not in range");
            //    }

            //     // nested if
            //    // if(number >= 1)
            //    //{
            //    //    if(number <= 10)
            //    //    {
            //    //        Console.WriteLine("You picked {0}", number);

            //    //    }
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Error: Not in range");
            //    //}
            //}
            //else
            //{
            //    Console.WriteLine("Error: Not a number");
            //}



            //if(number < 1 || number > 10)
            //{
            //    Console.WriteLine("Error: Not in range");
            //}

            //Console.Write("Enter the score: ");
            //int score = int.Parse(Console.ReadLine());

            //if(score >= 60)
            //{

            //    // nested if-else
            //    if(score >= 70)
            //    {
            //        if(score >= 80)
            //        {
            //            if(score >= 90)
            //            {
            //                Console.WriteLine("You got an A");
            //                //Environment.Exit(0); // quit the program
            //            }
            //            else
            //            {
            //                Console.WriteLine("You got a B");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("You got a C");
            //        }


            //       // Environment.Exit(0);
            //    }
            //    else
            //    {
            //        Console.WriteLine("You got an D");
            //    }    


            //    //Environment.Exit(0);
            //}


            // equvaulet to nested if-else
            //if(score <= 60)
            //{
            //    Console.WriteLine("You got a D");
            //}
            //else if(score <= 70)
            //{
            //    Console.WriteLine("You got a C");
            //}
            //else if(score <= 80)
            //{
            //    Console.WriteLine("You got a B");
            //}
            //else if(score <= 90)
            //{
            //    Console.WriteLine("You got an A");
            //}
            //else
            //{
            //    Console.WriteLine("You got an F");
            //}


            // Switch accepts two data types, int, string
            Console.Write("Enter a letter: ");
            string letter = Console.ReadLine().ToUpper(); // uppercase whatever is the input
            Console.WriteLine(letter);

            // accepts a specific data type.
            // You cannot use switch for range such as logical operators
            // case represent something that you want to matches with.
            switch(letter)
            {
                case "A":
                    Console.WriteLine("You picked an A");
                    break; // break is required for the case, it will jump out from switch
                case "B":
                    Console.WriteLine("You picked a B");
                    break;
                case "C":
                    Console.WriteLine("You picked a C");
                    break; // break is required for the case, it will jump out from switch
                case "D":
                    Console.WriteLine("You picked a D");
                    break;
                default: // similar as else
                    Console.WriteLine("The letter you picked does not exist.");
                    break;
            }

        }
    }
}
