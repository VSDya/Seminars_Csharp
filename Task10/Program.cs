// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    number = -number;
if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10;
    int result = secondDigit % 10;
    Console.WriteLine($"Вторая цифра числа -> {result}");
}
else
    Console.Write("Некорректное число");
