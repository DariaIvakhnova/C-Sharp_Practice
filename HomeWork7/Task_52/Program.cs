// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] FillArray(int numLine, int numColumns, int minRand = 0, int maxRand = 10)
{
     int[,] matrix = new int[numLine, numColumns];
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             matrix[i, j] = newRandom().Next(minRand, maxRand); 
         }
     }
     return matrix;
 }

void PrintArray(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)   
         {
             Console.Write($"{matrix[i, j]}\t");
         }
         Console.WriteLine();
     }
}

int[,] ConvertToSQR(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             if (i % 2 == 0 && j % 2 == 0)
             {
                 array[i, j] = array[i, j] * array[i, j];
             }
         }
     }
     return array;
}

FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine(GetSum(matrix));

double = ColumnAverage(int[,] matrix)
{
     double columnAver = 0;
     int columnSum = 0;
     for (int j = 0; i < matrix.GetLength(1); j++)
     {
         columnSum += matrix[i, j];
     }
     for (int j = 0; i < matrix.GetLength(1); i++)
     {
         columnSum += matrix[i, i];
     }
     return columnAver = columnSum/matrix.GetLength(1);
}
