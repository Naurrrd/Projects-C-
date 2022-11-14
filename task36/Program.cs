// Задача 36
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max);
    }
    return res;
}

void SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++) {if (i % 2 == 0) sum += array[i];}
    Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях: {sum}");
}

int[] A = GetArray(9, -15, 20);
Console.WriteLine($"[{String.Join(", ", A)}]");
SumOdd(A);