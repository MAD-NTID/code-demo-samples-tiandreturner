using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // int i = 0;
            //while(i < 10)
            //{
            //    Console.WriteLine(i);
            //     i++;
            //}

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

            Console.Clear();

             i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);


            //Console.Write("Enter a number: ");
            //while(!int.TryParse(Console.ReadLine(), out int number))
            //{
            //    Console.Write("Error -- Invalid number. Please Try Again.\nEnter a number: ");
            //}

            //Console.Write("Enter a positive number: ");
            //while (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
            //{
            //    if(number < 0)
            //    {
            //        Console.Write("Error -- the number cannot be a negative. Please Try Again.\nEnter a positive number: ");
            //        Environment.Exit(0);
            //    }
            //    //else
            //    //{
            //    //    Console.Write("Error -- the input you entered is not a numeric value. Please Try Again.\nEnter a positive number: ");
            //    //}
            //    Console.Write("Error -- the input you entered is not a numeric value. Please Try Again.");
            //}


            //while (true)
            //{
            //    Console.Write("Enter a positive number (enter 0 to quit): ");
            //    if (!int.TryParse(Console.ReadLine(), out int number))
            //    {

            //        Console.Write("Error -- the input you entered is not a numeric value. Please Try Again.");
            //    }
            //    else if (number < 0)
            //    {
            //        Console.WriteLine("Error -- the number cannot be a negative. Please Try Again.");
            //    }
            //    else if(number == 0)
            //    {
            //        //Environment.Exit(0);
            //        break;
            //    }
            //}

            //do
            //{
            //    int number = 1;
            //    int sum = 1;
            //    Console.Write("Enter a number to get the sum: ");
            //    int endNum = int.Parse(Console.ReadLine());

            //    while (number <= endNum)
            //    {
            //        sum += number;
            //        // Console.WriteLine(sum);
            //        number++;
            //    }

            //    Console.WriteLine("The sum is " + sum);

            //    Console.Write("Do you want to continue? (y/n): ");
            //} while (Console.ReadLine() == "y");


        }
    }
}
