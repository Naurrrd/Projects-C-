// Задача 43
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int[] Line1()
{
    Console.Write("Введите k1 и b1: ");
    int[] y1 = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return y1;
}
int[] Line2()
{
    Console.Write("Введите k2 и b2: ");
    int[] y2 = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return y2;
}

void IntersectionPoint(int[] y1, int[] y2)
{
    double k1 = y1[0];
    double b1 = y1[1];
    double k2 = y2[0];
    double b2 = y2[1];
    double x = (b2-b1) / (k1-k2);
    double y = k1 * x + b1;
    if (k1 == k2) {Console.Write("Прямые параллельны");}
    else Console.Write($"Точка пересечения прямых: х = {x}, y = {y}");
}

IntersectionPoint(Line1(), Line2());
