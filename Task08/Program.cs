// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число натуральное число (N)");
int numberN = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (numberN > index)
{
    Console.Write($"{index + 1}, ");
    index = index + 2;
}
