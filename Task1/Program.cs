class Program
{
    static void Main()
    {
        int[] numbers = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
        int count = 0;

        foreach (int number in numbers)
        {
            if (number >= 10 && number <= 90)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10, 90]: {count}");
    }
}