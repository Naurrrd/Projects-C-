// Задача 13: Напишите программу, которая выводит третью цифру (справа налево) 
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
string textnum = Convert.ToString(num);
if (textnum.Length > 2)
{
    int third = textnum.Length - 3;
    Console.Write($"Третья цифра с конца - {textnum[third]}");
}
else Console.Write("Третьей цифры нет");
