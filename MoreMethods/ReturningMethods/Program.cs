using System;

namespace ReturningMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoSomething("Doing something");

            //int num1 = EnterNumber();
            //Console.WriteLine(num1);
            //int num2 = EnterNumber();
            //Console.WriteLine(num2);

            //Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

            int num3 = EnterNumber();
            int num4 = EnterNumber();

            Console.WriteLine(DoPow(num3, num4));
            Console.WriteLine(DoPow(num3, num4, out long result));
            Console.WriteLine(result);

        }

        public static void DoSomething(string something)
        {
            Console.WriteLine(something);
        }

        public static void Shoot(string ball)
        {
            Console.WriteLine($"shooting {ball}");
        }

        public static int EnterNumber()
        {
            //Console.WriteLine(number);
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            return num;
        }

        public static int DoPow(int baseNumber, int power)
        {
            int result = 1;
            for(int i = 1; i <= power; i++)
            {
                result *= baseNumber;
            }

            return result;
        }



        public static bool DoPow(int baseNumber, int power, out long result)
        {
            result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= baseNumber;
            }

            if (result == 0)
                return false;

            return true;
        }
    }
}
