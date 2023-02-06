// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное чилсо: ");
int N = int.Parse(Console.ReadLine());
int n1 = N/1000;
int n2 = N%100;

if(N < 10000 || N > 99999)
{
    Console.WriteLine("Введено неверное число");
}
else 
{
  int n11 = n1/10;
  int n12 = n1%10;
  int n21 = n2/10;
  int n22 = n2%10;

  if(n11 == n22 && n12 == n21)
  {
    Console.WriteLine($"{N} -> да");
  }
  else
  {
    Console.WriteLine($"{N} -> нет");
  }
}
