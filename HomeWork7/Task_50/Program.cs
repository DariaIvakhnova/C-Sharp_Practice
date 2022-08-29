// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Random rand = new Random();

void FillMatrix(int[,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             matr[i, j] = rand.Next(1, 10);
         }
     }
}

void PrintArray(int[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
     }
}

int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintArray(matrix);

System.Console.WriteLine("Введите координаты: ");  // TODO за один ввод или два?
int a = Conver.ToInt32(Console.ReadLine();
int b = Conver.ToInt32(Console.ReadLine();

// int element = int.Parse(Console.ReadLine() ?? "0");



void findItem (int[,] matrix, int ...)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             if(i == a && j == b)
             {
               System.Console.WriteLine($"Данная ячейка содержит число {matrix[i,j]}.");
               return;
             }
         }

     }
     System.Console.WriteLine(Ячейки с такими индексами в массиве нет.");
}
                              
findElem(matrix, element);
                       
// void findElem (int[,] matrix, int element)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(element == matrix[i, j])
//             {
//               System.Console.WriteLine($"Entered number is on the [{i},{j}] position");
//               return;
//             }
//         }

//     }
//     System.Console.WriteLine($"There is no such element in this matrix");
// }


