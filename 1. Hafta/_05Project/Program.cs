using System;

namespace _05Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Values
            Console.Write("Hangi Dilleri biliyorsunuz? (İngilizce/Almanca): ");
            string language = Console.ReadLine().ToLower();

            Console.Write("Ofis Programlarını biliyorsunuz? (E/H): ");
            string officeProgram = Console.ReadLine().ToLower();

            // Control
            if ((language == "ingilizce" || language == "almanca") && officeProgram == "e")
            {
                Console.WriteLine("Tebrikler, İşe Başlayabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Üzgünüz, İşe Alınmadınız.");
            }
        }
    }
}