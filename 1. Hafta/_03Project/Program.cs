using System;

namespace _03Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables    
            int max = 0, min = 0, middle = 0;

            // Get Values
            Console.Write("1. Sayısı Giriniz: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayısı Giriniz: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Sayısı Giriniz: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            // Find Max Value
            if (number1 > number2 && number1 > number3)
            {
                max = number1;
            }

            if (number2 > number1 && number2 > number3)
            {
                max = number2;
            }

            if (number3 > number1 && number3 > number2)
            {
                max = number3;
            }

            // Find Min Value
            if (number1 < number2 && number1 < number3)
            {
                min = number1;
            }

            if (number2 < number1 && number2 < number3)
            {
                min = number2;
            }

            if (number3 < number1 && number3 < number2)
            {
                min = number3;
            }

            // Find Middle Value
            if (number1 != max && number1 != min)
            {
                middle = number1;
            }

            if (number2 != max && number2 != min)
            {
                middle = number2;
            }

            if (number3 != max && number3 != min)
            {
                middle = number3;
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine($"En Küçük Değer: {min}");
            Console.WriteLine($"Ortanca Değer: {middle}");
            Console.WriteLine($"En Büyük Değer: {max}");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }
    }
}