// Задача 50. 
// Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. 
// Программа должна возвращать значение позиции (номер строки и столбца) этого элемента 
// или же указание, что такого элемента нет.

int[,] GetArray(int minValue, int maxValue)
{
    Console.Write("Введите кол-во строк: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во стобцов: ");
    int cols = int.Parse(Console.ReadLine()!);
    int[,] result = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void FindNumberInArray(int[,] array)
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number) 
            {
                Console.WriteLine($"Данное число находится на {i} строке в {j} столбце");
                count++;
            }
        }
        // Console.WriteLine();
    }
    if (count == 0) {Console.Write("Такого числа в массиве нет");}
}

int[,] RandomArray = GetArray(0, 100);
PrintArray(RandomArray);
FindNumberInArray(RandomArray);