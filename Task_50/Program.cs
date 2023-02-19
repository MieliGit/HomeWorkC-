// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

Console.Clear();

int rows = Input("Введите число строк");
int colunns = Input("Введите число столбцов");

int[,] array = getArray(rows, colunns, 0 , 10);
PrintArray(array);

int in1 = Input("Введите номер строки числа, которого вы хотите получить");
int jn1 = Input("Введите номер столбца числа, которого вы хотите получить");
Console.WriteLine();
Point(array, in1, jn1);

int[,] getArray( int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Point(int[,] inArray, int inumber, int jnumber)
{
    int n = 0;
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
        if (inumber == i && jnumber == j) n = inArray[i,j];
        }
    }
    if (n> 0) Console.WriteLine($"Ваше число -> {n}");
    else Console.WriteLine("Вашего числа нет");
    Console.WriteLine();
}

int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

