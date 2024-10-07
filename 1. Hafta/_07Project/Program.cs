using System;

namespace _07Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double totalPrice = 0;
            int period1Minutes = 0, period2Minutes = 0;

            // Start
            Console.WriteLine("--------- HOŞGELDİNİZ ---------");
            Console.Write("Telefon Numaranız: ");
            string phone = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("1- Standart Paket (s-S)");
            Console.WriteLine("2- Premium Paket (p-P)");
            Console.Write("Paket Türü Seçiniz: ");
            string packageType = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Kullanım Süresi (Dakika): ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (packageType == "p" || packageType == "P")
            {
                Console.Write("06:00 – 18:00 Kullanım Süresi (Dakika): ");
                period1Minutes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.Write("18:00 – 06:00 Kullanım Süresi (Dakika): ");
                period2Minutes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                totalPrice = 25;

                if (period1Minutes > 75)
                {
                    totalPrice += (period1Minutes - 75) * 0.1;
                }

                if (period2Minutes > 100)
                {
                    totalPrice += (period2Minutes - 100) * 0.5;
                }
            }
            else
            {
                totalPrice = 10;
                if (minutes > 50)
                {
                    totalPrice += (minutes - 50) * 0.2;
                }
            }

            // Finish
            Console.WriteLine();
            Console.WriteLine("------------ FATURA DETAYLARI ------------");
            Console.WriteLine($"Telefon Numaranız: {phone}");
            Console.WriteLine($"Seçilen Paket: {packageType}");
            Console.WriteLine($"Konuşma Süresi: {minutes} Dakika");
            if (packageType == "p" || packageType == "P")
            {
                Console.WriteLine($"06:00 – 18:00 Kullanım Süresi: {period1Minutes} Dakika");
                Console.WriteLine($"18:00 – 06:00 Kullanım Süresi: {period2Minutes} Dakika");
            }
            Console.WriteLine($"Ödenecek Tutar: {totalPrice} TL");
            Console.WriteLine();
        }
    }
}