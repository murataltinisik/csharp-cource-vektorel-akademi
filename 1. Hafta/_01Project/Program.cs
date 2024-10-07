using System;

namespace _01Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Get Values
            Console.Write("1. Vize Notunu Giriniz: ");
            int vize1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Vize Notunu Giriniz: ");
            int vize2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final Notunu Giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());

            // Calculate
            double calculate = ((vize1 + vize2) / 2) * .40 + (final * .60);

            // Result
            if (calculate >= 50)
            {
                Console.WriteLine($"Tebrikler, {calculate} ortalama ile geçtiniz.");
            }
            else
            {
                Console.WriteLine($"Üzgünüz, {calculate} ortalama ile kaldınız.");
            }
        }
    }
}