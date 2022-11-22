// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetArray(int minValue, int maxValue)
{
    Console.Write("Введите кол-во строк: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во стобцов: ");
    int cols = int.Parse(Console.ReadLine()!);
    double[,] result = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1) + 
            new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(inArray[i,j], 1)} \t");
        }
        Console.WriteLine();
    }
}

double[,] RandomAarray = GetArray(0, 100);
PrintArray(RandomArray);