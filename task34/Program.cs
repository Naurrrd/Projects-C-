// Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void CountEven(int[] array)
{
    int even = 0;
    foreach (int i in array) {even += i % 2 == 0 ? 1 : 0;}
    Console.WriteLine($"Количество четных чисел: {even}");
}

int[] A = GetArray(6, 100, 999);
Console.WriteLine($"[{String.Join(", ", A)}]");
CountEven(A);