// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число N:");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M:");
int second = Convert.ToInt32(Console.ReadLine());

int SumNat(int first, int second)
{
    if (first == second) return first;
    return (first + SumNat(first+1, second));
}
Console.WriteLine(SumNat(first, second));