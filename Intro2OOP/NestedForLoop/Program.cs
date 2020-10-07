using System;

namespace NestedForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int outer = 0; outer < 2; outer++)
            //{
            //    Console.WriteLine("Outer: {0}", outer );
            //}

            //for (int inner = 0; inner < 3; inner++)
            //{
            //    Console.WriteLine("Inner: {0}", inner);
            //}

            int count = 1;
            for (int outer = 0; outer < 3; outer++)
            {
                for (int inner = 0; inner <= 4; inner++)
                {

                    Console.WriteLine(count);
                    Console.WriteLine("Outer: {0}\tInner: {1}", outer, inner);
                    count++;
                }
            }
        }
    }
}
