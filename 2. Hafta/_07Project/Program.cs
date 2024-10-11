using System;

namespace _07Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Values
            Console.Write("Biz Cümle Giriniz: ");
            string text = Console.ReadLine();

            // Split Text
            string[] parts = text.Split(' ');

            // Write Parts
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }
        }
    }
}