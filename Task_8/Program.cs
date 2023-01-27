// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int A = 2;

if(N%2 == 0) 
{
while(A < N)
{
    Console.Write(A +", ");
    A = A+ 2;
}
Console.WriteLine(N);
}
else 
{
    N = N - 1;
    while(A < N) {
    Console.Write(A +", ");
    A = A+ 2;
    }
    Console.WriteLine(N);
}
