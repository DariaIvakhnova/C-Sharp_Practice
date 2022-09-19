// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размер квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MatrixSpiralFilling(int size)
{
    int quantityOfElements = size * size; // кол-во элементов массива
    int elementCounter = 0; // счетчик элементов
    int start = 0; // первый элемент
    int[,] array = new int[size, size];
    while (elementCounter < quantityOfElements)
    {
        for (int i = start; i < size; i++) 
        {
            elementCounter++;
            array[start, i] = elementCounter;
        }
        for (int i = start + 1; i < size; i++)
        {
            elementCounter++;
            array[i, size - 1] = elementCounter;
        }
        for (int i = size - 2; i >= start; i--)
        {
            elementCounter++;
            array[size - 1, i] = elementCounter;
        }
        for (int i = size - 2; i >= start + 1; i--)
        {
            elementCounter++;
            array[i, start] = elementCounter;
        }
        size -= 1;
        start += 1;
    }
    return array;
}

int [,]matrix = MatrixSpiralFilling(size);
PrintMatrix(matrix);