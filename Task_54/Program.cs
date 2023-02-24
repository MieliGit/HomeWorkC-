// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int rows = Input("Введите число строк");
int colunns = Input("Введите число столбцов");
int min = Input("Введите минимальное число в массиве");
int max = Input("Введите максимальное чило в массиве");

int[,] array = getArray(rows, colunns, min , max);
int[,] sum = array;

PrintArray(array);
Console.WriteLine();
Sort(array);
Console.WriteLine();
PrintArray(array);

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

void Sort(int[,] inArray)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int z = 0; z < array.GetLength(1) - 1; z++)
      {
        if (array[i, z] < array[i, z + 1])
        {
          int temp = array[i, z + 1];
          array[i, z + 1] = array[i, z];
          array[i, z] = temp;
        }
      }
    }
  }
}





// {   
//     int[,] res = new int[inArray.GetLength(0), inArray.GetLength(1)]; 
   
//     for(int i=0; i<inArray.GetLength(0); i++)
//     {
//          int y = 0;
//          int z = inArray[0,y];
//         for(int j=0; j<inArray.GetLength(1); j++)
//         {
//         if(z >= inArray[i,j])
//         {
//             inArray[i,j] = z;
//         }
//         Console.Write($"{inArray[i,j]} ");
//         }
//          y++;
//     }
   
    
// }


    //  for(int j=0; j<inArray.GetLength(1); j++)
    //     {
    //         if(min >= inArray[i, j]) 
    //         {
    //             min = inArray[i, j];
    //         }
    //         else
    //         {
    //             inArray[i,j] = min;
    //         }
    //         Console.Write($"{inArray[i,j]} ");
    //     }
    //     Console.WriteLine();