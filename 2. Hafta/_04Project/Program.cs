using System;

namespace _04Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double total = 1000;

            // Get Values
            Console.Write("Kaç yıl kiralayacaksınız (2025, 2030 vs.): ");
            int year = Convert.ToInt32(Console.ReadLine());

            // LOOP
            for (int i = 2024; i < year; i++)
            {
                if (Convert.ToString(i).EndsWith("0"))
                {
                    total += 1000;
                }
                else
                {
                    total += (1000 * 1.05);
                }
            }

            // Finish
            Console.WriteLine();
            Console.WriteLine($"Sonuç: {total}");
        }
    }
}