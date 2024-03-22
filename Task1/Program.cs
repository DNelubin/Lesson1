// Вывести трехзначные числа с суммой последних двух каждого из них

int n=Convert.ToInt32(Console.ReadLine());
int fist = n%10;
int second = n/10%10;
int thri = n/100;
int sum = fist + thri;
Console.WriteLine(sum);