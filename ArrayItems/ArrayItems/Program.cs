using System;
using System.Collections.Generic;

namespace ArrayItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];
            try
            {
                numbers[0] = 23;
                numbers[1] = 32;
                numbers[2] = 42;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            foreach (int i in numbers)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
