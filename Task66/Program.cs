// Задача 66: 
// 1. Задайте значения M и N. 
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfElements(int numA, int numB)
{
    if (numA > numB) return numA + SumOfElements(numA - 1, numB);
    else if (numA == numB) return numA;
    else return numB + SumOfElements(numA, numB - 1);
}

Console.Write("Введите первое число M: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число N: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = SumOfElements(numberA, numberB);
Console.WriteLine($"M = {numberA}; N = {numberB} -> {result} ");
