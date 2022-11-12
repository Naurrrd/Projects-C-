// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void GetSum(int A)
{
    int sum = 0;
    while (A!=0)
    {
        sum = sum + A%10;
        A = A/10;
    }
    Console.Write($"Сумма цифр: {sum}");
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
GetSum(N);