// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
// Функция ввода 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void RowRemakePosition(int[,] arr)
{
    int lastRowIndex = arr.GetLength(0);
    int firstRowIndex = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[firstRowIndex, j];
        arr[firstRowIndex, j] = arr[lastRowIndex - 1, j];
        arr[lastRowIndex - 1, j] = temp;
    }
}


int[,] array2d = CreateMatrixRndInt(rows, columns, 0, 10);
Console.WriteLine("Созданная матрица:");
PrintArray(array2d);
RowRemakePosition(array2d);
Console.WriteLine();
PrintArray(array2d);