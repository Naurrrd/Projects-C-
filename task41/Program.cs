// Задача 41
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void CountPositive()
{
    Console.Write("Введите несколько чисел через пробел: ");
    int[] M = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    int positive = 0;
    for (int i = 0; i < M.Length; i++)
    {
        if (M[i] > 0) {positive++;}
    }
    Console.WriteLine($"Количество положительных чисел: {positive}");
}

CountPositive();