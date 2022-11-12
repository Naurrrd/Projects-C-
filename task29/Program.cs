// Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArray8()
{
    int[] array8 = new int[8];
    for (int i = 0; i < array8.Length; i++)
    {
        Console.Write($"Введите {i} число: ");
        array8[i] = int.Parse(Console.ReadLine()!);
    }
    return array8;
}
int [] array = GetArray8();
Console.Write($"[{String.Join(", ", array)}]");