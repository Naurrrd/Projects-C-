void Pal(int N)
{
    int cel = N/1000;
    int ost = N%100;
    if (cel/10 == ost%10 && cel%10 == ost/10) Console.Write("Это палиндром!");
    else Console.Write("Это не палиндром!");
}

Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
Pal(n);