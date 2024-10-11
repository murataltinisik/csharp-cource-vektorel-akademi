using System;

namespace _03Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int result = 1;

            // Get Values
            Console.Write("Bir Sayı Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kuvvet bilgisini giriniz: ");
            int pow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // LOOP
            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }

            // Finish
            Console.WriteLine();
            Console.WriteLine($"Sonuç: {result}");
        }
    }
}