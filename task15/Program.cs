﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int a = int.Parse(Console.ReadLine()!);
if (a < 8 && a > 0)
{
    if (a == 6 || a == 7)
    {
        Console.Write("Выходной");
    }
    else Console.Write("Не выходной");
}
else Console.Write("Введите корректную цифру");