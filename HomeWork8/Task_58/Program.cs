// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int lines = 2; // Задаем изначально равные по размеру матрицы
int columns = 2;
Random rand = new Random();

Console.WriteLine("Первая матрица: ");

int[,] firstMatrix = new int[lines, columns];
for (int i = 0; i < firstMatrix.GetLength(0); i++)  
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)     
    {
        firstMatrix[i, j] = rand.Next(1, 9);
        Console.Write($"{firstMatrix[i, j]}\t");   
    }
    Console.WriteLine();
}

Console.WriteLine("Вторая матрица: ");

int[,] secondMatrix = new int[lines, columns];
for (int i = 0; i < secondMatrix.GetLength(0); i++)  
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)     
    {
        secondMatrix[i, j] = rand.Next(1, 9);
        Console.Write($"{secondMatrix[i, j]}\t");   
    }
    Console.WriteLine();
}

Console.WriteLine("Результирующая матрица: ");

int[,] resultMatrix = new int[lines, columns];
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < secondMatrix.GetLength(0); k++)
        {
            resultMatrix[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
        }
        Console.Write($"{resultMatrix[i, j]}\t");
    }
    Console.WriteLine();
}