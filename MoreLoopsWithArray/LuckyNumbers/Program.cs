using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_GUESS_ATTEMPTS = 5;
            const int MAX_NUMBER = 50;

            Random rand = new Random();
            int[] luckyNumbers = new int[3];

            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                luckyNumbers[i] = rand.Next(MAX_NUMBER);
            }
            
            //int currentGuess = 0;
            //for (int i = 1; i <= MAX_GUESS_ATTEMPTS; i++)
            //{
            //    Console.Write($"Lucky guess #{i}: ");
            //    currentGuess = int.Parse(Console.ReadLine());

            //    for(int j = 0; j < luckyNumbers.Length; j++)
            //    {
            //        if(currentGuess == luckyNumbers[j])
            //        {
            //            Console.WriteLine("WOW! You got it right!");
            //            Environment.Exit(0);
            //        }
            //    }
            //}

            Console.Write($"Aw shucks! the lucky numbers are ");
            foreach (int luckyNumber in luckyNumbers)
            {
                Console.Write($"{luckyNumber} ");
            }

            int sum = 0;
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                sum += luckyNumbers[i];
            }

            Console.WriteLine($"The sum of the lucky numbers is {sum}");



            //int luckyNumber = rand.Next(MAX_NUMBER); // get a random number from 1 to max number (50)

            //for(int i = 1; i <= MAX_GUESS_ATTEMPTS; i++)
            //{
            //    Console.Write($"Lucky guess #{i}: ");
            //    currentGuess = int.Parse(Console.ReadLine());

            //    if(currentGuess == luckyNumber)
            //    {
            //        Console.WriteLine("WOW! You got it right!");
            //        Environment.Exit(0);
            //    }
            //    else if(currentGuess < luckyNumber)
            //    {
            //        Console.WriteLine("Aw, go a little bit higher");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Aw, go a little bit lower");
            //    }
            //}

            // Console.WriteLine($"Aw shucks! the lucky number is {luckyNumber}");
        }
    }
}
