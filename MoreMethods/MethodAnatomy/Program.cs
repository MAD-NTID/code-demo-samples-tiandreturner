using System;

namespace MethodAnatomy
{
    class Program
    {
        public static string doSomething = "Do something...";
        static  int number = 3;
        static void Main(string[] args)
        {
            //Console.Write("Enter a number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(num1);
            EnterNumber();
            EnterNumber();

           

            //Console.Write("Enter a number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(num2);
        }

        public static void DoSomething()
        {
            
            Console.WriteLine(number);
            Console.WriteLine(doSomething);
        }

        public static void EnterNumber()
        {
            Console.WriteLine(number);
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(num);
        }
    }
}
