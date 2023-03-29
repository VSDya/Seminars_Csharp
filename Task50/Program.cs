// Задача 50. 
// 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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
            Console.Write($"{matrix[i, j],4} "); // 4} отступ между элементами
        }
        Console.WriteLine();
    }

}

bool FindElementByIndex(int[,] matrix, int a, int b)
{
    if (a < matrix.GetLength(0) && b < matrix.GetLength(1)) return true;
    else return false;
}

int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine("Введите индекс ячейки");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
string output = FindElementByIndex(array2d, numA, numB) ? $"Элемент с индексом {numA}, {numB} -> присутствует в массиве" : $"{numA}, {numB} -> такого элемента в массиве нет";
Console.WriteLine(output);
