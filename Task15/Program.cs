// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    if (number < 6) Console.WriteLine($"{number} -> Нет");
    else Console.WriteLine($"{number} -> Да");
}
else
    Console.WriteLine("Некорректное число");
