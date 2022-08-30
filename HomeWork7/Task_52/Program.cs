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
     return columnAver = columnSum/matrix.GetLength(0);
}

// вариант от Гаи:
void NewRandomMatrix (int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(10, 100);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Сначала объединила эти два метода, но потом передумала и вернула как было

void FindTheElement (int str, int col, int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (str - 1 >= matr.GetLength(0) || col - 1 >= matr.GetLength(1))
        {
            System.Console.WriteLine("There is no such position in this matrix");
            break;
        }    
    
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == str - 1 && j == col - 1)
            {
                System.Console.WriteLine($"The 
System.Console.WriteLine("What string is the element on? : ");
int str = int.Parse(Console.ReadLine() ?? "0");

System.Console.WriteLine("Which column is the element in? : ");
int col = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine();

int[,] matrix = new int[6, 6];
NewRandomMatrix(matrix);
FindTheElement(str, col, matrix);