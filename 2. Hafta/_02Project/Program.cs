using System;

namespace _02Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int result = 0;

            // Loop
            for (int i = 1; i <= 1000; i++)
            {
                result += i;
            }

            // Result
            Console.WriteLine();
            Console.WriteLine($"Sonuç: {result / 1000}");
        }
    }
}