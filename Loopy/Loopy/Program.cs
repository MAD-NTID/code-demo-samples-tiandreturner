using System;
using System.Threading;

namespace Loopy
{
    class Program
    {

        public Program()
        {
            MyProperty = 1;
        }
        private int number;
        public int MyProperty { get { return number; } set { number = value; } }
        static void Main(string[] args)
        {
           for(int i = 0; i < 10;  i++)
            {
                Console.WriteLine(i);

                if (i == -1)
                {
                    Console.WriteLine("Breaking out of the loop");
                    break;
                }
            }

            firstMethod();
            secondMethod();
            thirdMethod();

            string abc = "abc";
            Console.WriteLine(abc[2]);

            char a = 'a';
            //char ab = 'ab';
            char one = '1';

            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Starting over again!");

            do
            {
                Console.Clear();
                Console.WriteLine("1. FirstMethod");
                Console.WriteLine("2. SecondMethod");
                Console.WriteLine("3. ThirdMethod");

                Console.Write("Pick a method: ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        firstMethod();
                        break;
                    case 2:
                        secondMethod();
                        break;
                    case 3:
                        thirdMethod();
                        break;
                }

                Console.Write("Do you want to continue? (y/n): ");
            } while (Console.ReadLine() == "y");


        }

        public static void firstMethod()
        {
            Console.WriteLine("First method");
        }

        public static void secondMethod()
        {
            Console.WriteLine("second method");
        }

        public static void thirdMethod()
        {
            Console.WriteLine("Third method");
        }
    }
}
