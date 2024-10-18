namespace _03Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            bool isEquals = false;

            // Strings
            Console.Write("1. Değeri Giriniz: ");
            string str1 = Console.ReadLine();

            Console.Write("2. Değeri Giriniz: ");
            string str2 = Console.ReadLine();

            // String to char array
            char[] charInStr1 = str1.ToCharArray();
            char[] charInStr2 = str2.ToCharArray();

            // Sort char array with Array.Sort()
            Array.Sort(charInStr1);
            Array.Sort(charInStr2);

            // Are Str1 and Str2 equals
            for (int i = 0; i < str1.Length; i++)
                if (charInStr1[i] == charInStr2[i]) isEquals = true;

            // Control isEqual variable
            if (isEquals)
                Console.WriteLine($"{str1} ve {str2} değerleri anagramdır.");
            else
                Console.WriteLine($"{str1} ve {str2} değerleri anagram değidir.");
        }
    }
}