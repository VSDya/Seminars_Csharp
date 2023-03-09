// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;

// Console.Write(result);

int DelDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}");
int newNumber = DelDigit(number);
Console.WriteLine($"Новое число -> {newNumber}");