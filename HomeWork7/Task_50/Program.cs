// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] NewRandomMatrix(int lines, int columns, int minRand, int maxRand)
{
    int [,] matrix = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minRand,maxRand);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
        }
    return matrix;
}

int[,] newMatrix = NewRandomMatrix(3, 4, 1, 10);
int lines = 3; // Искусственно выношу переменные из функции, чтобы использовать их дальше в сравнении (34)
int columns = 4;

Console.WriteLine("Введите индекс строки элемента: "); // Запрашиваю именно индекс. Иначе: в строке (36) вывода 
int indexLine = Convert.ToInt32(Console.ReadLine());   // значения из индексов нужно вычитать 1 и использовать
Console.WriteLine("Введите индекс столбца элемента: ");// "<=" в сравнении (34)
int indexColumn = Convert.ToInt32(Console.ReadLine());

if (indexLine < lines && indexColumn < columns)
{
    Console.WriteLine($"Элемент с индексами [{indexLine},{indexColumn}] : {newMatrix[indexLine, indexColumn]}");
}
else
{
    Console.WriteLine("Элемента с такими индексами не существует в данном массиве.");
}

