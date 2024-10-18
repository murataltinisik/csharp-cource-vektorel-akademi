using System;

namespace _01Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string newValue = "";

            // Get values to user
            Console.Write("Bir Değer Giriniz: ");
            string input = Console.ReadLine();

            // Create Random Ref
            Random random = new Random();

            // Mix Input Value
            for (int i = 0; i < input.Length; i++)
            {
                newValue += input[random.Next(1, input.Length)];
            };

            // Write value
            Console.WriteLine();
            Console.WriteLine($"Yeni Değer: {newValue}");
        }
    }
}