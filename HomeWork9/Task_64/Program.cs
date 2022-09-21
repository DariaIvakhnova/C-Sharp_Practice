﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) 
    {
        return start;
    }
    return PrintNumbers(start + 1, end); // возвращается к вызову метода
}

Console.Clear();
Console.Write("Введите M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int numberN = int.Parse(Console.ReadLine());
int temp = 0;
if (numberM > numberN) // цикл обмена значениями для случая, когда М > N
{
    temp = numberM;
    numberM = numberN;
    numberN = temp;
}
PrintNumbers(numberM,numberN);