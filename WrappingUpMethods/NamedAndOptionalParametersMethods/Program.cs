using System;

namespace NamedAndOptionalParametersMethods
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

            //Console.WriteLine(DoPow(num3, num4));
            //Console.WriteLine(DoPow(power: num4, baseNumber: num3)); // this is called named parameter
            //Console.WriteLine(DoPow(num4, num3));
            //Console.WriteLine(DoPow(num3, num4, out long result));
            //Console.WriteLine(result);

            DoSomething();
            DoSomething("I am doing something!");

            Console.WriteLine(AddNumbers(num3, num4));
            Console.WriteLine(AddNumbers(num3));
        }

        public static void DoSomething(string something = "this is my optional string")
        {
            Console.WriteLine(something);
        }

        //public static int AddNumbers(int firstNumber = 2, int secondNumber = 5)
        //{
        //    return firstNumber + secondNumber;
        //}

        /// <summary>
        /// Adds all of three numbers
        /// </summary>
        /// <param name="firstNumber">The first number</param>
        /// <param name="secondNumber">The second number that comes with an default value of 5 as an option</param>
        /// <param name="thirdNumber">The third number that comes with an default value of 6 as an option</param>
        /// <returns></returns>
        public static int AddNumbers(int firstNumber, int secondNumber = 5, int thirdNumber =6) // This is called optional parameters
        {
            return firstNumber + secondNumber + thirdNumber;
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
            for (int i = 1; i <= power; i++)
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
