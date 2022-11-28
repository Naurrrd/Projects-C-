// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] GetSquareArray()
{
    int[,] result = new int[4, 4];
    int current = 1, i = 0, j = 0;
    while (current <= 16)
    {
        result[i, j] = current;
        current++;
        if (i <= j + 1 && i + j < 3)
            j++;
        else if (i < j && i + j >= 3)
            i++;
        else if (i >= j && i + j > 3)
            j--;
        else
            i--;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,2:D2} ", inArray[i, j]));
        }
        Console.WriteLine();
    }
}

int[,] arrayA = GetSquareArray();
PrintArray(arrayA);
