// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//вариант Гаи:
void CreateRandomMatrix (double[,] matrix)
{
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rand.NextDouble() * 30 - 10; // формула для увеличения интервала рандомизации
      Console.Write("{0,8:F2}", matrix[i, j]);
    }
    Console.WriteLine();
  }
}

// мой вариант:
double [,] NewCustomMatrix (int numLines, int numColumns, int minRand, int maxRand)
{
  double[,] matrix = new double[numLines, numColumns];
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = newRandom().Next(minRand, maxRand) * (maxRand - minRand) + minRand; // формула для увеличения диапазона рандома вещественных чисел; 
      Console.Write("{0:F2}", matrix[i, j]);
    }
    Console.WriteLine(); // нужен ли ретерн?
  }
}

Console.WriteLine("Введите количество строк: ");
int numLines = Convert.ToInt32(Console.Readline());
Console.WriteLine("Введите количество столбцов: ");
int numColumns = Convert.ToInt32(Console.Readline());
Console.WriteLine("Введите минимальную границу диапазона значений: ");
int minRand = Convert.ToInt32(Console.Readline());
Console.WriteLine("Введите максимальную границу диапазона значений: ");
int naxRand = Convert.ToInt32(Console.Readline());

double [,] newMatrix = NewCustomMatrix (numLines, numColumns, minRand, maxRand);

// вариант из семинара:
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

// + метод печати:
// void PrintMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] array = FillArray(Prompt("Введите число строк: "),Prompt("Введите число столбцов: "));
// PrintArray(array);
