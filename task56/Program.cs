// Задача 56. 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int GetSumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++) {sumLine += array[i, j];}
    return sumLine;
}


void MinLineSumInArray(int[,] array)
{
    int minLineSum = 0;
    int minSum = GetSumLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumLine = GetSumLine(array, i);
        if (sumLine < minSum)
        {
            minSum = sumLine;
            minLineSum = i;
        }
    }
    Console.WriteLine($"Строкa с наименьшей суммой элементов ({minSum}) - {minLineSum + 1}. ");
}

int[,] RandomArray = GetArray(-5, 20);
PrintArray(RandomArray);
MinLineSumInArray(RandomArray);
