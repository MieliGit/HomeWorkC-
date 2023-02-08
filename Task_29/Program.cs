// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] arr = new int[8];

PrintArray(arr);


void PrintArray(int[] array)
{
    for(int i = 0; i<8; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i]+ " ");
    }
}

