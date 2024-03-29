﻿// Задача 64: 
// 1. Задайте значение N. 
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0) Console.WriteLine("Введено нулевое или отрицательное значение");
else
{
    Console.Write($"N = {number} -> ");
    NaturalNumber(number);
}

void NaturalNumber(int num) // обратная рекурсия
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumber(num - 1);
}
