// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число, которое хотите возвести в степень: ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую хотите возвести число: ");
double s = double.Parse(Console.ReadLine());

PrintPow(n);

void PrintPow(double n1)
{
   n1 = Math.Pow(n, s);
   Console.WriteLine($"{n}, {s} -> {n1}");
}
