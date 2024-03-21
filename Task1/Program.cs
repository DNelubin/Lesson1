class Program
{
    static void Main()
    {
        int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
        int count = 0;

        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {count}");
    }
}