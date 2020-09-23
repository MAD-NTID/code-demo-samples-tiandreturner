using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // increase by 1 from 0 to 4
            // num++: num = num + 1
            //for(int num = 0; num < 5; num++)
            //{
            //    Console.WriteLine(num);
            //}

            //for (int num = 0; num <= 5; )
            //{
            //    Console.WriteLine(num);
            //    num++;
            //}

            // num--: num = num - 1
            //for (int num = 20; num >= 0; num--)
            //{
            //    Console.WriteLine(num);
            //}

            // num+=5: num = num + 5
            //for (int num = 0; num <= 100; num+=5)
            //{
            //    Console.WriteLine(num);
            //}

            // num+=num: num = num + num
            //for (int num = 1; num < 10; num+=num)
            //{
            //    Console.WriteLine(num);
            //}

            //for (int num = 0; num <= 1000; num++)
            //{
            //    if(num % 25 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //Console.Write("Enter a number: ");
            //int endNum = int.Parse(Console.ReadLine());

            //for (int num = 0; num <= endNum; num++)
            //{
            //    Console.WriteLine(num);
            //}

            Console.Write("Enter a start number: ");
            int startNum = int.Parse(Console.ReadLine());

            for (int num = startNum; num <= 100; num++)
            {
                Console.WriteLine(num);
            }
        }
    }
}
