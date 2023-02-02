// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int N = new Random().Next(1, 10000);
int N1 = 0;
if(N < 100) 
{
    Console.WriteLine(N + " -> третьей цифры нет");
}
else 
{
    if(N < 1000)
    {
        N1 = N%10;
        Console.WriteLine(N + " -> " + N1);
    }
    else
    {
        N1 = N/10;
        N1 = N1%10;
        Console.WriteLine(N + " -> " + N1);
    }
}
