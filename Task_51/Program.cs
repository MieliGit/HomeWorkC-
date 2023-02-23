// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();

int rows = Input("Введите число строк");
int colunns = Input("Введите число столбцов");

int[,] array = getArray(rows, colunns, 0 , 10);
PrintArray(array);

Console.WriteLine();

double[] averageColumns = GetAref(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ", averageColumns)}");

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

double GetAref(int[,] inArray)
{
    double[] res = new double[inArray.GetLength(1)];
    for(int j=0; j<inArray.GetLength(1); j++)
    {
        double sum = 0;
        for(int i=0; i<inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        res[j] = Math.Round(sum/ inArray.GetLength(0), 2);
    }
    return res;
}


int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}
