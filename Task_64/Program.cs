// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.Clear();
 
int M = Input("Введите число");


NumberListRec(M);

void NumberListRec(int a)
{
    int count = a;
    Console.Write($"{count} ");
    if(a <= 1) return;
    else NumberListRec(a - 1);
}


int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}