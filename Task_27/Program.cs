// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

PrintSum(n);

void PrintSum(int number)
{
    int sum = 0;
    int n1 = 0;

   for (int i = 0; i < number; i++)
    {
      n1 = number - number % 10;
      sum = sum + (number - n1);
      number = number / 10;
    }
    Console.WriteLine(sum);
}
