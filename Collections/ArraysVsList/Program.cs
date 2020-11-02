using System;
using System.Collections.Generic;

namespace ArraysVsList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(8);
            numbers.Add(24);
            numbers.Add(7);
            numbers.Add(25);
            numbers.Add(11);
            numbers.Add(23);

            Console.WriteLine($"There are {numbers.Count} numbers in the list");

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            //int[] numbersArray = new int[5000];
        }
    }
}
