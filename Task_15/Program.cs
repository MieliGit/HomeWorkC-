// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число от 1 до 7");
int N = int.Parse(Console.ReadLine());

if(N > 8)
{
    Console.WriteLine("Введено неверное число");
}
else 
{
    if(N<6)
    {
        Console.WriteLine(N + " -> No");
    }
    else
    {
        Console.WriteLine(N + " -> Yes");
    }
}