// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
 
int M = Input("Введите начальное число");
int N = Input("Введите конечное число");

Console.WriteLine(NumberListRec(M, N));

int NumberListRec(int a, int b)
{
    if(b == a) return b;
    else return b + NumberListRec(a, b - 1);
}


int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}