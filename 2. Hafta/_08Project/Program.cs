using System;

namespace _08Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            bool isSuccess = false;
            int totalOfTenNumbers = 0, totalOfOddNumbers = 0, totalOfEvenNumbers = 0;

            // Get Values
            Console.Write("Tc Kimlik Numaranızı Giriniz: ");
            string identity = Console.ReadLine();

            // Controls
            if (identity.Length == 11 && !identity.StartsWith("0"))
            {
                for (int i = 0; i < identity.Length; i++)
                {
                    // Get ASCII code
                    int code = Convert.ToInt32(identity[i]);

                    // Character convert to string
                    string character = Convert.ToString(identity[i]);

                    switch (i)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 9:
                            totalOfOddNumbers += Convert.ToInt32(character);
                            break;
                        case 2:
                        case 4:
                        case 6:
                        case 8:
                            totalOfEvenNumbers += Convert.ToInt32(character);
                            break;
                    }

                    // Sum, first ten characters
                    if (i < 10)
                    {
                        totalOfTenNumbers += Convert.ToInt32(character);
                    }

                    // Control
                    if (!(code >= 48 && code <= 57))
                    {
                        Console.WriteLine("Tc Kimlik Numaranız Geçersiz formatta!!");
                    }
                    else
                    {
                        // Identity is success
                        isSuccess = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Tc Kimlik Numaranız 11 haneli olmalıdır!");
            }


            if (isSuccess)
            {
                // Convert ToString -> totalOfTenNumbers
                string totalOfTenNumbersString = Convert.ToString(totalOfTenNumbers);

                // OnesPlace
                char onesPlace = totalOfTenNumbersString[totalOfTenNumbersString.Length - 1];

                // Ones Place is equal identiy last character
                if (onesPlace == identity[identity.Length - 1])
                {
                    Console.WriteLine("Eşittir");
                }

                // Find Tenth Digit
                double tenthDigit = ((totalOfOddNumbers * 7) - totalOfEvenNumbers) % 10;

                // Find Eleventh Digit
                double eleventhDigit = totalOfTenNumbers % 10;

                Console.WriteLine();
                Console.WriteLine($"KİMLİK NO: {identity}");
                Console.WriteLine($"10. HANE: {tenthDigit}");
                Console.WriteLine($"11. HANE: {eleventhDigit}");
                Console.WriteLine();
            }
        }
    }
}