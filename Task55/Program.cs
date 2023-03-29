// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine();
    }
}
// Метод замены строк на столбцы поочередный, с возможностью выбора не симметричных матриц. 

// int[,] CreateNewArray(int[,] arr)
// {
//     int[,] matrix = new int[arr.GetLength(1), arr.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = arr[j, i];
//         }
//     }
//     return matrix;
// }

bool IsSquareMatrix(int[,] arr)
{
    return arr.GetLength(0) == arr.GetLength(1);
}

void TransposeMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            int temp = arr[j, i];
            arr[j, i] = arr[i, j];
            arr[i, j] = temp;
        }
    }
}

int[,] array2d = CreateMatrixRndInt(rows, columns, 0, 10);
Console.WriteLine("Созданная матрица:");
PrintArray(array2d);
if (IsSquareMatrix(array2d))
{
    TransposeMatrix(array2d);
    Console.WriteLine("Развёрнутая матрица с заменой строк на столбцы методом треугольника:");
    PrintArray(array2d);
}
// if (array2d.GetLength(0) == array2d.GetLength(1)) // Если убрать условие, то для любых размеров матрицы
// {
//     int[,] newArray2d = CreateNewArray(array2d);
//     Console.WriteLine("Матрица с заменой строк на столбцы:");
//     PrintArray(newArray2d);
// }
else Console.WriteLine("Матрица не симметричная.");
