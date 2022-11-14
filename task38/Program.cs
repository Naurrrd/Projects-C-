// Задача 38
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void Def(int[] array)
{
    int max = array[0];
    int min = array[0];
    int i = 1;
    while (i < array.Length) 
    {
        if (array[i] > max) {max = array[i];}
        if (array[i] < min) {min = array[i];}
        i++;
    }
    int defference = max-min;
    Console.WriteLine($"Разница между наибольшим и наименьшим элементами: {defference}");
}

int[] A = GetArray(10, -20, 20);
Console.WriteLine($"[{String.Join(", ", A)}]");
Def(A);