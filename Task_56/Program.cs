//  Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int rows = Input("Введите число строк");
int colunns = Input("Введите число столбцов");
int min = Input("Введите минимальное число в массиве");
int max = Input("Введите максимальное чило в массиве");

int[,] array = getArray(rows, colunns, min , max);

PrintArray(array);
Console.WriteLine();

int minSum = 0;
int sum = Sum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = Sum(array, i);
  if (sum > temp)
  {
    sum = temp;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - строка с наименьшей суммой элементов ");

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

int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

int Sum(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


//  if (array[i, z] < array[i, z + 1])
//         {
//           int temp = array[i, z + 1];
//           array[i, z + 1] = array[i, z];
//           array[i, z] = temp;
//         }