using System;

namespace _01Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int total = 0;

            // Get Values
            Console.Write("1. Sayısı Giriniz: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayısı Giriniz: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Loop
            for (int i = number1; i <= number2; i++)
            {
                total += i;
            }

            // Finish
            Console.WriteLine();
            Console.WriteLine($"Sayıları Toplamı: {total}");
        }
    }
}