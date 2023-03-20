// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int countDigit = CountDigit(num);
Console.WriteLine($"В числе {num} содержится {countDigit} цифр(ы)");

int CountDigit(int number)
{
    int quantityDigit = 0;
    do
    {
        number /= 10; // number = number / 10;
        quantityDigit++;
    } while (number != 0); // постусловие 0 тоже цифра
    return quantityDigit;
}

// Ещё одно решение

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int digits = Digits(number);
// Console.WriteLine($"{number} -> {digits}");

// int Digits(int num)
// {
//     if (num < 0) num = -num;
//     int count = 0;
//     while(num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }
