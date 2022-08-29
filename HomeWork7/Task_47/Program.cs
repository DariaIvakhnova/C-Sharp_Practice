// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] FillArray(int numLine, int numColumns, double minRand = -10, double maxRand = 10)
// {
//     int[,] matrix = new int[numLine, numColumns]; // нужно ли тут менять на дабл?
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = newRandom().Next(minRand, maxRand); 
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
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
