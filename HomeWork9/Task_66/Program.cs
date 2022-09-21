// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumInsideInterval(int start, int end)
{
    if (start == end) 
    {
        return start;
    }
    return start + SumInsideInterval(start+1, end);
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

SumInsideInterval(numberM,numberN);
Console.WriteLine($"Сумма натуральных элементов в промежутке [M;N] = {(SumInsideInterval(numberM,numberN))}");