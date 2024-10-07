using System;

namespace _02Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double result = 0;

            // Get Values
            Console.Write("1. Sayıyı Giriniz: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Start
            Console.WriteLine("");
            Console.WriteLine("--------- İŞLEMLER ----------");
            Console.WriteLine("(+) Toplama");
            Console.WriteLine("(-) Çıkartma");
            Console.WriteLine("(*) Çarpma");
            Console.WriteLine("(/) Bölme");
            Console.WriteLine("(%) Mod Alma");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            Console.Write("İşlem Türünü Seçiniz: ");
            string processType = Console.ReadLine();

            if (processType == "+")
            {
                result = number1 + number2;
            }

            if (processType == "-")
            {
                result = number1 - number2;
            }

            if (processType == "*")
            {
                result = number1 * number2;
            }

            if (processType == "/")
            {
                result = number1 / number2;
            }

            if (processType == "%")
            {
                result = number1 % number2;
            }

            // Finish
            Console.WriteLine("");
            Console.WriteLine("-------- SONUÇ --------");
            Console.WriteLine($"{number1} {processType} {number2} = {result}");
            Console.WriteLine("");
        }
    }
}