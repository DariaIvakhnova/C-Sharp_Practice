// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] NewCustomMatrix (int numLines, int numColumns, double minRand, double maxRand)
{
  double[,] matrix = new double[numLines, numColumns];
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rand.NextDouble() * (maxRand - minRand) + minRand; // формула для увеличения диапазона рандома вещественных чисел; 
      Console.Write($"{matrix[i, j]:F1}\t");
    }
    Console.WriteLine();
  }
  return matrix;
}

Console.Write("Введите количество строк: ");
int numLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную границу диапазона значений: ");
double minRand = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальную границу диапазона значений: ");
double maxRand = Convert.ToDouble(Console.ReadLine());

double [,] newMatrix = NewCustomMatrix (numLines, numColumns, minRand, maxRand);
