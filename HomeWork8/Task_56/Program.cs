// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

int lines = 4;
int columns = 5;
int minRand = 1;
int maxRand = 10;
int sumLine = 0;
Random rand = new Random();
int [,] matrix = new int[lines, columns];
Random rand2 = new Random();    // создаем одномерный массив, который будет заполняться суммами 
int[] array = new int[lines]; // элементов строк двумерного массива
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rand.Next(minRand,maxRand);
        sumLine += matrix[i,j];
        Console.Write($"{matrix[i, j]}\t");
    }
    array[i] = sumLine;
    Console.WriteLine();
    sumLine = 0;
}

int minSum = array[0];
int linesCounter = 0;
for (int k = 1; k < lines; k++)
{
    if (array[k] < minSum)
    {
        minSum = array[k];
        linesCounter = k+1;
    }
}
Console.WriteLine($"Сумма элементов в {linesCounter} строке является наименьшей.");