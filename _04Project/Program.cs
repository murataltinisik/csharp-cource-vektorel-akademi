using System;

namespace _04Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double average1 = 0, average2 = 0, average3 = 0;

            // Get Values
            Console.Write("1. Sayıyı Giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Sayıyı Giriniz: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("4. Sayıyı Giriniz: ");
            int d = Convert.ToInt32(Console.ReadLine());

            // Start
            if ((a > b && b > c && c > d) || (a < b && b < c && c < d))
            {
                average1 = (b + a) / 2;
                average2 = (c + b) / 2;
                average3 = (d + c) / 2;
            }
            else
            {
                Console.WriteLine("Sayılar sıralı bir şekilde girilmelidir!");
            }

            // Print Console
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"b ve a'nın ortalaması: {average1}");
            Console.WriteLine($"c ve b'nin ortalaması: {average2}");
            Console.WriteLine($"d ve c'nin ortalaması: {average3}");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
        }
    }
}