// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int size = Input("Введите размер массива");
int min = Input("Введите минимальное вещественное число в массиве");
int max = Input("Введите максимальное вещественное число в массиве");

int[] array = GetArray(size, min, max);
PrintArray(array);
Console.WriteLine();
Dif(array);

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

int Dif(int[] someArray)
{
    int dif = 0;
    int maxNumber = 0;
    int minNumber = 0;
    for(int i = 0; i < someArray.Length; i++)
    {
        if(someArray[i] > maxNumber) maxNumber = someArray[i];
    }
    Console.WriteLine($"max = {maxNumber}");
    minNumber = maxNumber;
    for(int i = 0; i < someArray.Length; i++)
    {
         if(someArray[i] < minNumber) minNumber = someArray[i];
    }
    Console.WriteLine($"mix = {minNumber}");
    dif = maxNumber - minNumber;
    Console.WriteLine($"{maxNumber} - {minNumber} = {dif}");
    return dif;
}