// Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

void getAinPowB(int A, int B)
{
    int powed = 1;
    for (int i=1;i<=B;i++) {powed = powed*A;}
    Console.Write($"А в степени В: {powed}");
}

Console.Write("Введите A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine()!);
getAinPowB(a,b);