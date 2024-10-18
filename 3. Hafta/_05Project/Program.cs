namespace _05Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            int[] numbers = { 1, 2, 3, 4, 5, 2, 2, 2, 2 };
            int maxNumberOfRepetitions = 0, repatedNumber = numbers[0];

            // Loop numbers array
            for (int i = 1; i < numbers.Length; i++)
            {
                // Repated Number For Loop
                int numberOfRepetitionsInLoop = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numberOfRepetitionsInLoop++;
                    }
                }

                // Check Value
                if (numberOfRepetitionsInLoop > maxNumberOfRepetitions)
                {
                    maxNumberOfRepetitions = numberOfRepetitionsInLoop;
                    repatedNumber = numbers[i];
                }
            }

            // Finish
            Console.WriteLine();
            Console.WriteLine($"En Çok Tekrar Eden Sayı: {repatedNumber}");
            Console.WriteLine($"Tekrar Sayısı: {maxNumberOfRepetitions}");
        }
    }
}