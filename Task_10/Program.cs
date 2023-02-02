// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int N1 = int.Parse(Console.ReadLine());
int N = 0;
int N2 = 0;
if(N1>999)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    if(N1<99)
    {
        Console.WriteLine("Введено неверное число");
    }
    else
    {
        N = N1/10;
        N = N%10;
        Console.WriteLine(N);
    }
}

