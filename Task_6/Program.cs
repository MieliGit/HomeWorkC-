﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число");
int N1 = int.Parse(Console.ReadLine());

if(N1%2 == 0) 
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}