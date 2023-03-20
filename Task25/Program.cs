// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumber(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {degreeNumber}");

int DegreeNumber(int numA, int numB)
{
    int result = numA;
    int i = 1;
    while (i < numB)
    {
        checked
        {
            result = result * numA;
            i++;
        }
    }
    return result;
}
