﻿// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5     7   -2  -0,2
//   1  -3,3    8  -9,9
//   8   7,8 -7,1     9

Console.Write("Задайте количество строк двумерного массива m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов двумерного массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array2d = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{matr[i, j],4} ");
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
    }
}
FillArray(array2d);
Console.WriteLine();
PrintArray(array2d);
