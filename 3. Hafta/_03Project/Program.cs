namespace _03Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int[] numbers = { 1, 2, 3, 4, 11, 5, -1, 6, 7, 200, 8, 9 };
            int max = numbers[0], min = numbers[0];

            // Find max and min values
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            // Move place
            int maxValueIndex = Array.IndexOf(numbers, max);
            int minValueIndex = Array.IndexOf(numbers, min);

            numbers[minValueIndex] = max;
            numbers[maxValueIndex] = min;

            // Write Updated array
            foreach (int i in numbers) Console.WriteLine(i);
        }
    }
}