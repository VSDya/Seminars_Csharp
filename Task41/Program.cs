// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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
    Console.Write("]");
}

int QuantityPositiveNumbers(int[] arr)
{
    int sumNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumNumber += arr[i];
    }
    return sumNumber;
}

Console.Write("Введите размер массива M чисел: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(sizeArray, -10, 10);
PrintArray(array);

int quantityPositiveNumbers = QuantityPositiveNumbers(array);
Console.Write($" -> {quantityPositiveNumbers}");