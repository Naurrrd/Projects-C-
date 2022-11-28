// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetUnicArray(int minValue, int maxValue)
{
    Console.Write("Введите X: ");
    int x = int.Parse(Console.ReadLine()!);
    Console.Write("Введите Y: ");
    int y = int.Parse(Console.ReadLine()!);
    Console.Write("Введите Z: ");
    int z = int.Parse(Console.ReadLine()!);
    int[,,] result = new int[x, y, z];

    bool FindElement(int[,,] array, int el)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    if (array[i, j, k] == el) return true;
                }
            }
        }
        return false;
    }

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                int element = new Random().Next(minValue, maxValue + 1);
                while (FindElement(result, element)) 
                {
                    element = new Random().Next(minValue, maxValue + 1);;
                };
                result[i, j, k] = element;
            }
        }
    }
    return result;
}


void PrintArray(int[,,] inArray)
{
    for (int k = 0; k < inArray.GetLength(2); k++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


int[,,] arrayA = GetUnicArray(0, 100);
PrintArray(arrayA);
