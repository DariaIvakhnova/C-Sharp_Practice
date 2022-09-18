// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Исходный массив:");

int[,] matrix = new int[3,4];
Random rand = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = rand.Next(1, 9);
        Console.Write($"{matrix[i,j]}\t");
    }
    Console.WriteLine();
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

int[,] SortElemInLine(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++) // Создаем как бы еще одну плоскость,"кальку" за нашим основным массивом
            {
                if (matrix[i,j] > matrix[i,k])
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
        }
    }
    return matrix;
}

Console.WriteLine("Массив, отсортированный по убыванию элементов в строке:");
SortElemInLine(matrix);
PrintArray(matrix);