﻿// Вывести трехзначные числа с суммой последних двух каждого из них

Console.WriteLine(" выведи трехзначное число: ");
string n = Console.ReadLine()!;

if (n.Length != 3)
{
    Console.Write("это не трехзначное число...");
}
else
{
    Console.WriteLine(Convert.ToInt32(Convert.ToString(n[0])) + Convert.ToInt32(Convert.ToString(n[2])));
}