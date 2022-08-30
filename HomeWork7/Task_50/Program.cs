// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] NewRandomMatrix(int lines, int columns, int minRand, int maxRand)
{
    int[,] matrix = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next();
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    return matrix;
}



int[,] matrix = new int[3, 4];
Random rand = new Random();
int counterOfLines = 0;
int counterOfColumns = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rand.Next(1, 9);
        Console.Write($"{matrix[i, j]}\t");
        counterOfColumns++;
    }
    Console.WriteLine();
    counterOfLines++;
}

int[,] newMatrix = NewRandomMatrix(3, 4, 1, 10);

Console.WriteLine("Введите индекс строки элемента: ");
int numLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца элемента: ");
int numColumn = Convert.ToInt32(Console.ReadLine());

if (numLine <= counterOfLines && numColumn <= counterOfColumns)
{
    Console.WriteLine($"Элемент с индексами [{numLine},{numColumn}] : {matrix[numLine, numColumn]}");
}
else
{
    Console.WriteLine("Элемента с такими индексами не существует в данном массиве.");
}