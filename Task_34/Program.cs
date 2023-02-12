// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int size = Input("Введите размер массива");
int min = 100;
int max = 1000;

int[] array = GetArray(size, min, max);
PrintArray(array);
Console.WriteLine();
EvenNumber(array);

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


int EvenNumber(int[] someArray)
{
    int count = 0;
    for(int i = 0; i< someArray.Length; i++)
    {
        if(someArray[i]%2 == 0) count++;
    }
    Console.WriteLine(count);
    return count;
}
