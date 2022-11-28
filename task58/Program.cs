// Задача 58. 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void MultiplicationArrays(int[,] array1, int[,] array2)
{
    int rows2 = array2.GetLength(0);
    int rows3 = array1.GetLength(0);
    int cols3 = array2.GetLength(1);
    int[,] array3 = new int[rows3, cols3];
    for (int i = 0; i < rows3; i++)
    {
        for (int j = 0; j < cols3; j++)
        {
            array3[i, j] = 0;
            for (int k = 0; k < rows2; k++) {array3[i, j] += array1[i, k] * array2[k, j];}
        }   
    }
    Console.WriteLine("Результат произведения матриц:");
    PrintArray(array3);
}

int[,] arrayA = GetArray(0, 100);
PrintArray(arrayA);
int[,] arrayB = GetArray(0, 100);
PrintArray(arrayB);
MultiplicationArrays(arrayA, arrayB);
