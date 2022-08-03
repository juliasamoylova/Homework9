// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
Console.Write("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());

static int Acker(int m, int n)
{
    if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
    if (n == 0) return m + 1;
    if (m == 0) return Acker(n - 1, m);
    return Acker(n - 1, Acker(n, m - 1));
}
Console.WriteLine(Acker(m, n));