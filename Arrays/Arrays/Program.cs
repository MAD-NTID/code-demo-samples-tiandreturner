using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // we are going to start with something simple.
            // creating six integer variables

            // there are two ways to create variables
            // 1. 
            int num1, num2, num3, num4, num5, num6;
            num1 = 3;
            num2 = 11;

            // variables always will hold only one value

            // 2.
            int number1 = 3;
            int number2 = 11;
            int number3 = 44;
            int number4 = 23;
            int number5 = 64;
            int number6 = 50;

            // very simple

            // With an array, it is a little bit different.
            // it is like a tackle box.
            int[] numbers = new int[6];

            // storing numbers in each element
            numbers[0] = 3;
            numbers[1] = 11;
            numbers[2] = 44;
            numbers[3] = 23;
            numbers[4] = 64;
            numbers[5] = 50;

            // this is another way to create an array
            int[] diffNumbers = { 1, 2, 3, 4, 5, 6 };

            // retriving a value from a specific position in array.
            Console.WriteLine(numbers[3]);
            int number = numbers[2]; // retriving a value and store it to a variable

            // Getting the length of the array
            Console.WriteLine($"There are {numbers.Length} elements in numbers array");

            // Getting the sum of all elements
            int total = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5];
            Console.WriteLine("The total sum of the array is: " + total);

            // getting string of favorite foods
            string[] favoriteFoods = new string[6];
            favoriteFoods[0] = Console.ReadLine();
            favoriteFoods[1] = Console.ReadLine();
            favoriteFoods[2] = Console.ReadLine();
            favoriteFoods[3] = Console.ReadLine();
            favoriteFoods[4] = Console.ReadLine();
            favoriteFoods[5] = Console.ReadLine();

            // get the 5th element
            Console.WriteLine("The favorite food of the day is " + favoriteFoods[4]);

            // Generate Random Number
            Random rng = new Random();
            // getting a random number from 1 - 6
            int index = rng.Next(favoriteFoods.Length);

            // Getting any random number with no limitation
            int diffNumber = rng.Next();

            // Displaying the differences.
            Console.WriteLine($"Index: {index}\nNumber: {diffNumber}");

            // randomly select the index from the array
            Console.WriteLine("The favorite food of the day is " + favoriteFoods[index]);
        }
    }
}
