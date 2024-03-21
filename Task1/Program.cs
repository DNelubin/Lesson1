class Program
{
    static void Main()
    {
        double[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
        
        double maxNum = array[0];
        double minNum = array[0];

        foreach (double num in array)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
            if (num < minNum)
            {
                minNum = num;
            }
        }

        double diff = maxNum - minNum;
        
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");
    }
}