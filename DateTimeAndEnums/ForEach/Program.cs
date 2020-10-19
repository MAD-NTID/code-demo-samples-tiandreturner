using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 67, 8, 9, 6, 500, 20, 78 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string[] names = { "T", "J" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
