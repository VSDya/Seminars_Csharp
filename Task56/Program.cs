// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int[] SumOfRows(int[,] matrix)
{
    int size = 0;
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[size] = sum;
        size++;

    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write($"  ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"");
}

int FindingSmallestRowSum(int[] arr)
{
    int count = 0;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            count = i;
        }
    }
    return count + 1;

}

int[,] matrix = CreateMatrixRndInt(5, 4, 0, 11);
PrintMatrix(matrix);
int[] sumOfRows = SumOfRows(matrix);
int findingSmallestRowSum = FindingSmallestRowSum(sumOfRows);
Console.WriteLine();
Console.Write(" Суммы всех строк:");
PrintArray(sumOfRows);
Console.WriteLine();
Console.WriteLine($" Номер строки с наименьшей суммой элементов:  {findingSmallestRowSum}");