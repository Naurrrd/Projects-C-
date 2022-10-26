// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

void getLen(double x1, double y1, double x2, double y2, double z1, double z2)
{   Console.Write($"L = {Math.Round(Math.Sqrt
    (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2-z1, 2)),2)}");
}

Console.Write("X1 = ");
double X1 = double.Parse (Console.ReadLine ()!);
Console.Write("Y1 = ");
double Y1 = double.Parse (Console.ReadLine ()!);
Console.Write("Z1 = ");
double Z1 = double.Parse (Console.ReadLine ()!);
Console.Write("X2 = ");
double X2 = double.Parse (Console.ReadLine ()!);
Console.Write("Y2 = ");
double Y2 = double.Parse (Console.ReadLine ()!);
Console.Write("Z2 = ");
double Z2 = double.Parse (Console.ReadLine ()!);

getLen(X1,Y1,Z1,X2,Y2,Z2);
