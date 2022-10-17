// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
if (a > b && a > c)
    Console.Write($"Наибольшее число - {a}");
else if (b > a && b > c)
    Console.Write($"Наибольшее число - {b}");
else
    Console.Write($"Наибольшее число - {c}");