// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max) // Создание случайного массива вещественных чисел
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr) // Запись массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double FindMinNumber(double[] arr) // Метод нахождения минимального числа
{
    double minNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}

double FindMaxNumber(double[] arr)  // Метод нахождения максимального числа
{
    double maxNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}

double GetDiffMaxMinNumbers(double[] arr)   // Метод вычисления разницы между максимальным и минимальным числом
{
    return FindMaxNumber(arr) - FindMinNumber(arr);
}

double[] array = CreateArrayRndDouble(5, 0, 99);
PrintArrayDouble(array);
double minNum = FindMinNumber(array);
double maxNum = FindMaxNumber(array);
double diffMaxMinNumbers = Math.Round(GetDiffMaxMinNumbers(array), 1);
Console.WriteLine($" -> {diffMaxMinNumbers}");
