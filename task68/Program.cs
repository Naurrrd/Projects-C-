// Задача 68.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Введите неотрицательное m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"A({m}, {n}) = {Akkerman(m, n)}");