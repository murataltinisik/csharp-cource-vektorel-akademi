using System;

namespace _06Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int budget = 0;
            bool isSuccess = false;
            string homeOptionsByType;
            int rentalVilla = 50000, saleVilla = 1000000;
            int rentalApartment = 5000, saleApartment = 100000;

            // Welcome
            Console.WriteLine("--------- HOŞGELDİNİZ ---------");
            Console.WriteLine("1- Daire");
            Console.WriteLine("2- Villa");
            Console.WriteLine();

            // Get Value - homeType
            Console.Write("Seçiniz (1/2): ");
            string homeType = Console.ReadLine();
            Console.WriteLine("-------------------------------");

            if (homeType == "1")
            {
                Console.WriteLine();
                Console.WriteLine("3- Satılık Daire (3)");
                Console.WriteLine("4- Kiralık Daire (4)");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("5- Satılık Villa (5)");
                Console.WriteLine("6- Kiralık Villa (6)");
                Console.WriteLine();
            }

            // Get Value - homeOptionsByType
            Console.Write("Seçiniz: ");
            homeOptionsByType = Console.ReadLine();
            Console.WriteLine();

            if (homeOptionsByType != "")
            {
                Console.Write("Bütçenizi Giriniz: ");
                budget = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (homeOptionsByType == "3")
                {
                    if (budget >= saleApartment)
                    {
                        isSuccess = true;
                    }
                }

                if (homeOptionsByType == "4")
                {
                    if (budget >= rentalApartment)
                    {
                        isSuccess = true;
                    }
                }

                if (homeOptionsByType == "5")
                {
                    if (budget >= saleVilla)
                    {
                        isSuccess = true;
                    }
                }

                if (homeOptionsByType == "6")
                {
                    if (budget >= rentalVilla)
                    {
                        isSuccess = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir değer giriniz!");
            }

            // Finish
            if (isSuccess)
            {
                Console.WriteLine("İşlem Başarılı!");
            }
            else
            {
                Console.WriteLine("İşlem Başarısız, Bütçe Yetersiz!");
            }
        }
    }
}