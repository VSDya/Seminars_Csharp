// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = DelDigit(number);
Console.WriteLine($"Новое число -> {newNumber}");

int DelDigit(int num)
{
    int secondDigit = num / 10;
    int result = secondDigit % 10;
    return result;
}
