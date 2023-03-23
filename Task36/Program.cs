// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumOddNumIndex(int[] arr)
{
    int sumNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sumNum += arr[i];
    }
    return sumNum;
}

int[] array = CreateArrayRndInt(6, -99, 99);
PrintArray(array);
int sumOddNumIndex = SumOddNumIndex(array);
Console.WriteLine($"Сумма чисел по нечетному индексу = {sumOddNumIndex}");
