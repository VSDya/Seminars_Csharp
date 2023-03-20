// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} -> {sumDigits}");

int SumDigits(int num)
{
    if (num < 0) num = -num;
    int lastDigit = 0;
    while (num > 0)
    {
        lastDigit = lastDigit + num % 10;
        num = num / 10;
    }
    return lastDigit;
}
