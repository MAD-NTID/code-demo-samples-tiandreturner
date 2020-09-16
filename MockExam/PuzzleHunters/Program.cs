using System;

namespace PuzzleHunters
{
    /**
     * Name: Tiandre Turner
     * Date: 09/16/2020
     * Purpose: Create a program that the owner will be able to purchase 
     * or sell the puzzle games from/to the customers.
     * Caveats: any issues you have in the code. struggling with the problems
     */
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            const double PUZZLE_GAME_PRICE = 19.95;
            int numOfPuzzleGames = 0;
            string menu = "\n1. Purchase puzzle games from the customers\n" +
                          "2. Sell puzzle games to the customers\n" +
                          "3. Display the current value of the inventory\n" +
                          "Select one of the options: ";

            Console.Write("Enter the number of the puzzle games in the store: ");
            // validating if the input is a numeric value
            if(!int.TryParse(Console.ReadLine(), out numOfPuzzleGames))
            {
                Console.WriteLine("Invalid Input... Quitting the program");
                Environment.Exit(0);
            }

            Console.Write(menu);
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Write("How many puzzle games would you like to purchase: ");
                    
                    if (!int.TryParse(Console.ReadLine(), out int puzzleGamePurchase))
                    {
                        Console.WriteLine("Invalid Input... Quitting the program");
                        Environment.Exit(0);
                    }

                    numOfPuzzleGames = numOfPuzzleGames + puzzleGamePurchase;
                    // OR numOfPuzzleGames += puzzleGameSell;

                    Console.WriteLine("Current number of puzzle games in the store - {0}\nCurrent value - {1:C}",
                        numOfPuzzleGames, numOfPuzzleGames * PUZZLE_GAME_PRICE);
                    break;
                case "2":
                    Console.Write("How many puzzle games would you like to sell: ");

                    if (!int.TryParse(Console.ReadLine(), out int puzzleGameSell))
                    {
                        Console.WriteLine("Invalid Input... Quitting the program");
                        Environment.Exit(0);
                    }

                    numOfPuzzleGames = numOfPuzzleGames - puzzleGameSell;

                    // OR numOfPuzzleGames -= puzzleGameSell;

                    Console.WriteLine("Current number of puzzle games in the store - {0}\nCurrent value - {1:C}",
                        numOfPuzzleGames, numOfPuzzleGames * PUZZLE_GAME_PRICE);
                    break;
                case "3":
                    Console.WriteLine("Current number of puzzle games in the store - {0}\nCurrent value - {1:C}",
                  numOfPuzzleGames, numOfPuzzleGames * PUZZLE_GAME_PRICE);
                    break;
                default:
                    Console.WriteLine("Invalid Input... Quitting the program");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
