using System;

namespace ForLoopsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classList = {"Hy'suon Hill", "James Hughes", 
                "Molly Mikkelson", "Joshua Howell-Leyer", "William Arnold"};

            Console.WriteLine($"There are {classList.Length} students in the class");
            for(int index = 0; index < classList.Length; index++)
            {
                Console.WriteLine(classList[index]);
            }


            Console.Write("Enter the number of new students to be added in the class: ");
            int additionalStudents = int.Parse(Console.ReadLine());
            int oldArraySize = classList.Length;

            Array.Resize(ref classList, oldArraySize + additionalStudents);

            for(int index = 0; index < additionalStudents; index++)
            {
                Console.WriteLine($"{index + 1}. Enter student's name: ");
                classList[oldArraySize + index] = Console.ReadLine();
            }

            Console.WriteLine($"There are {classList.Length} students in the class");
            for (int index = 0; index < classList.Length; index++)
            {
                Console.WriteLine(classList[index]);
            }
        }
    }
}
