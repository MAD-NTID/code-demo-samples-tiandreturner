using System;

namespace MockPracticalExam2
{
    class Program
    {
        static Alien[] aliens = new Alien[0];
        static void Main(string[] args)
        {
            int choice;

            DisplayHeading();

            while (true)
            {
                choice = GetMainMenuChoice();
                Console.WriteLine(choice);
                switch (choice)
                {

                    case 1:
                        EnterASighting();
                        break;
                    case 2:
                        DisplayAllSightings();
                        break;
                    case 3:
                        FilterBySpecies();
                        break;
                    case 4:
                        DisplayRecordCount();
                        break;
                    case 5:
                        ExitProgram();
                        break;
                }
            }
        }

        private static void ExitProgram()
        {
            Console.WriteLine("BUH-BYE");
            Environment.Exit(0);
        }

        private static void DisplayRecordCount()
        {
            Console.WriteLine($"There are {aliens.Length} sightings on file"); 
        }

        private static void FilterBySpecies()
        {
            int count = 0; // counting how many species that matches with the requested search.
            string name;
            Console.Write("Enter the species name to list: ");
            if ((name = Console.ReadLine()) == "") // IF it is empty. it was != "". Should be == ""
                return;

            for (int i = 0; i < aliens.Length; i++)
            {
                Console.WriteLine(aliens[i].Name == name);
                if (aliens[i].Name == name)
                {
                    Console.WriteLine($"{aliens[i].Name}\t{aliens[i].Date.ToLongDateString()}\t{aliens[i].Location}");
                    count++;
                }
            }

            Console.WriteLine($"{count} sightings reported for species: {name}");


        }

        private static void DisplayAllSightings()
        {
            for(int i = 0; i < aliens.Length; i++)
            {
                Console.WriteLine($"{aliens[i].Name}\t{aliens[i].Date.ToLongDateString()}\t{aliens[i].Location}");
            }

            Console.WriteLine($"{aliens.Length} sightings reported");
        }

        private static void EnterASighting()
        {
            DateTime date;

            Console.WriteLine("\nEnter the species for this sighting: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the date of the sighting (mm/dd/yyyy): ");
            while(!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Invalid date. Try again");
            }

            Console.WriteLine("Enter the location (state) where the sighting occurred: ");
            string location = Console.ReadLine();

            Array.Resize(ref aliens, aliens.Length + 1);
            Alien alien = new Alien(name, date, location);

            aliens[aliens.Length - 1] = alien;

            Console.WriteLine("1 new sighting added");
            //new Alien()
        }

        public static void DisplayHeading()
        {
            Console.WriteLine($"MAD4UFOS Data Collection System\n{DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}");
        }

        public static int GetMainMenuChoice()
        {
            int choice;
            bool outOfRange = false;
            string error;
            string menu = "   1. Enter a sighting\n   2. Display all sightings\n   3. Display sightings filtered by species" +
                "\n   4. Display records count\n   5. Exit\nEnter your selection (1-5): ";
            Console.WriteLine("Main Menu");
            Console.WriteLine("------------");
            Console.Write(menu);


            while(!int.TryParse(Console.ReadLine(), out choice) || (outOfRange =  (choice <= 0 || choice > 5)))
            {
                if (outOfRange)
                    error = "The selected option is not within the menu";
                else
                    error = "Invalid Input";

                Console.Write($"{error}. Please Try Again.\n\n{menu}");
            }

            return choice;
        }
    }
}
