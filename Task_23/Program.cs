// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число: ");
double N = double.Parse(Console.ReadLine());
double a = 1;
double b = 1;
if (N < 0)
{
N = N*-1;
}

while(a < N)
{
b = Math.Pow(a ,3);
a++;
Console.Write(b + ", ");
}
N = Math.Pow(N ,3);
Console.Write(N);