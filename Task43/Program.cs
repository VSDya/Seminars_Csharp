// Задача 43: 
// 1. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double CoordPosX(double b1, double k1, double b2, double k2)
{
    double x = 0;
    if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else x = (b2 - b1) / (k1 - k2);
    return x;
}

double CoordPosY(double b1, double k1, double b2, double k2)
{
    double y = 0;
    if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    return y;
}

Console.Write("Введите b1: ");
var bCoord1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var kCoord1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var bCoord2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var kCoord2 = Convert.ToDouble(Console.ReadLine());

double x = CoordPosX(bCoord1, kCoord1, bCoord2, kCoord2);
x = Math.Round(x, 2);
double y = CoordPosY(bCoord1, kCoord1, bCoord2, kCoord2);
y = Math.Round(y, 2);
Console.WriteLine($"b1 = {bCoord1}, k1 = {kCoord1}, b2 = {bCoord2}, k2 = {kCoord2} -> ({x}; {y})");
