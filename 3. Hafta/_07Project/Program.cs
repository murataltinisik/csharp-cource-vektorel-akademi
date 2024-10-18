using System;

namespace _07Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable
            Console.Write("Bir değer giriniz: ");
            string text = Console.ReadLine().ToLower();

            // Text to Char Array
            char[] textArray = text.ToCharArray();

            // Find Repated Characters
            for (int i = 0; i < textArray.Length; i++)
                for (int j = i + 1; j < textArray.Length; j++)
                    if (textArray[i] == textArray[j]) textArray[i] = '-';

            // Finish
            string result = new string(textArray).Replace("-", "");

            // Write Console
            Console.WriteLine("Sonuç: {0}", result);
        }
    }
}