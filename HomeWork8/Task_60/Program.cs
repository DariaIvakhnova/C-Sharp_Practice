// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Random rand = new Random();
int[,,] NewMatrix = new int[2,2,2]; // заполнение массива рандомными двухзначными числами
for (int i = 0; i < NewMatrix.GetLength(0); i++)  
{
    for (int j = 0; j < NewMatrix.GetLength(1); j++) 
    {
        for (int k = 0; k < NewMatrix.GetLength(2); k++)   
        {
            NewMatrix[i, j, k] = rand.Next(10,99); 
        }
    }
}

Console.WriteLine("Трехмерный массив: ");
for (int i = 0; i < NewMatrix.GetLength(0); i++)  // вывод массива
{
    for (int j = 0; j < NewMatrix.GetLength(1); j++) 
    {
        for (int k = 0; k < NewMatrix.GetLength(2); k++)   
        {
            Console.Write($"{NewMatrix[i, j, k]} ({j},{k},{i})\t");   
        }
        Console.WriteLine();
    }
}