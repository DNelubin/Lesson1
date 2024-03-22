// Напишите программу, которая на вход принимает два целых числа и проверяет является ли первое число квадратом второго

Console.Write("Введите первое число:");
int namber1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int namber2 = Convert.ToInt32 (Console.ReadLine());

if(namber1 == namber2 * namber2)
{
    Console.Write($"Квадрат числа {namber2} равен {namber1}");
}
else Console.Write("Квадрат числа {0} не равен {1}", namber2, namber1);