// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int num, int arg)
{
    if (num == 0) return arg + 1;
    if (num != 0 && arg == 0) return AckermanFunction(num - 1, 1);
    else return AckermanFunction(num - 1, AckermanFunction(num, arg - 1));
}

bool IsNotNegativeNum(int num)
{
    return num >= 0;
}

Console.Write("Введите число функции: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите аргумент функции: ");
int argument = Convert.ToInt32(Console.ReadLine());
if (IsNotNegativeNum(number) && IsNotNegativeNum(argument))
{
    int result = AckermanFunction(number, argument);
    Console.WriteLine($"m = {number}, n = {argument} -> A(m,n) = {result}");
}
else Console.WriteLine("Введенно отрицательное число, вычисление произвести невозможно");