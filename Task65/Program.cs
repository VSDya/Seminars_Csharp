// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа от {numberM} до {numberN}:");
ShowNumbers(numberM, numberN);

void ShowNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        ShowNumbers(numM, numN - 1);
        Console.Write($"{numN} ");
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        ShowNumbers(numM - 1, numN);
    }
    else
    {
        Console.Write($"{numM} ");
    }
}
