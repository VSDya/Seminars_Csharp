// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int number = 1;
    int i = 0;
    int j = 0;

    while (number <= rows * columns)
    {
        matrix[i, j] = number;
        if (i <= j + 1 && i + j < rows - 1) j++;
        else if (i < j && i + j >= rows - 1) i++;
        else if (i >= j && i + j > rows - 1) j--;
        else
            i--;
        number++;
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = CreateMatrixRndInt(4, 4);
PrintMatrix(matrix);
