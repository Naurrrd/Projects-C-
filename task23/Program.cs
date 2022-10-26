// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void getPows(int N)
{
    for (int i=1;i<=N;i++) Console.Write((Math.Pow(i,3)).ToString() + ((i!=N) ? ", " : ""));
}

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
getPows(n);