// Задача 64.
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

string NaturalNumbers(int N)
{
    if (N == 1) return N.ToString();
    return $"{N}, {NaturalNumbers(N - 1)}";
}

int N;
N = 10;
Console.WriteLine($"N = {N} -> {NaturalNumbers(N)}");