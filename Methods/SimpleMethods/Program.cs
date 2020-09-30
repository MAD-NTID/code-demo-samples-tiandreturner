using System;

namespace SimpleMethods
{
    class Program
    {
       // static string message;
        static void Main(string[] args)
        {
            PrintHello();
            PrintHello();
            PrintHello();
            PrintHello();
            PrintMore();

            PrintMessage();
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();
            PrintMessage(message);
        }

        public static void PrintMessage()
        {
            Console.WriteLine("PrintMessage: I am showing off my skills!");
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine("PrintMessage: " + message);
        }

        public static void PrintMore()
        {
            Console.WriteLine("I am looking forward to watch the NBA finals!");
            Console.WriteLine("Can have more than two statements");
        }

        // This is a method
        public static void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }

        


    }
}
