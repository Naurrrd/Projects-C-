// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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

void FindAverageInCols(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double average = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++) {sum += array[j,i];}
        average = Math.Round((sum / array.GetLength(0)), 2);
        Console.Write(average + ((i != array.GetLength(1)-1) ? "; " : "."));
    }
}

int[,] RandomArray = GetArray(0, 100);
PrintArray(RandomArray);
FindAverageInCols(RandomArray);