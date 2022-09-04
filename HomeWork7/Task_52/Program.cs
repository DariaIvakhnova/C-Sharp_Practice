// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMatrix(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
}

 void PrintMatrix(int[,] massif)
 {
     for (int i = 0; i < massif.GetLength(0); i++)
    {
        for (int j = 0; j < massif.GetLength(1); j++)
        {
            Console.Write($"{massif[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void GetAverageForColumn(int[,] matrix)
{
    double sumForColumn = 0;
    double averageForColumn = 0;
    for (int j = 0; j < matrix.GetLength(1); j++) // Меняем местами очередность (i <-> j) прохождения по массиву,
    {                                             // т.о. проходим поочередно столбцы и считаем сумму элементов в них.
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumForColumn += matrix[i, j];
        }
        averageForColumn = Convert.ToDouble(sumForColumn/matrix.GetLength(0));
        Console.WriteLine($"Среднее арифметическое значений {j+1} столбца = {averageForColumn.ToString("F1")};");
        sumForColumn = 0;
    }
}

int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
GetAverageForColumn(matrix); 
