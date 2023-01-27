// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите первое число");
int NumberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int NumberTwo = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if(NumberOne > NumberTwo) 
{
    max = NumberOne;
    min = NumberTwo;
}
else
{
    max = NumberTwo;
    min = NumberOne;
}
Console.Write("Максимальное число = ");
Console.WriteLine(max);
Console.Write("Минимальное число = ");
Console.WriteLine(min);
