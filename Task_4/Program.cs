// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите первое число");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int N3 = int.Parse(Console.ReadLine());
int max = 0;
if(N1 > N2)
{
    if(N1 > N3)
    {
        max = N1;
    }
    else 
    {
        max = N3;
    }
}
else
{
   if(N2 > N3)
    {
        max = N2;
    }
    else 
    {
        max = N3;
    }
}

Console.Write("max = ");
Console.WriteLine(max);
