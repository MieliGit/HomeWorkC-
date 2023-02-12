// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int size = Input("Введите четный размер массива: ");
int min = Input("Введите минимальное число в массиве: ");
int max = Input("Введите максимальное число в массиве: ");

int[] array = GetArray(size, min, max);
PrintArray(array);
Console.WriteLine();
Sum(array);

int[] GetArray(int sizeArray, int minNumber, int maxNumber)
{
    int[] res =new int[sizeArray];
    for(int i = 0; i < sizeArray; i++)
    {
        res[i] = new Random().Next(minNumber, maxNumber +1);
    }
    return res;
}

void PrintArray(int[] SomeArray)
{
    Console.Write("[");
    for (int i = 0; i < SomeArray.Length -1; i++)
    {
        Console.Write($"{SomeArray[i]}, ");
    }
    Console.Write($"{SomeArray[SomeArray.Length -1]}] ");
}


int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

int Sum(int[] someArray)
{
    int sum = 0;
    for(int i = 0; i < someArray.Length; i++)
    {
        if(i%2 == 0) sum = sum + someArray[i];
    }
    Console.WriteLine(sum);
    return sum;
}