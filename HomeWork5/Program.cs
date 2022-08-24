// Прописываю функции, которые далее потребуются для решения задач

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] myArray = CreateRandomArray(4, 100, 999);
// ShowArray(myArray);

// int evenAmount = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
// if (myArray[i] % 2 == 0)
// evenAmount++;
// }

// Console.WriteLine($"Четных чисел в массиве: {evenAmount}");


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// int[] myArray = CreateRandomArray(4, -100, 100);
// ShowArray(myArray);

// int sumOddIndex = 0;

// for (int i = 1; i < myArray.Length; i += 2) //первой нечетной позицией считаем индекс 1
// {
//    sumOddIndex += myArray[i];
// }

// Console.WriteLine($"Сумма элементов с нечетными индексами = {sumOddIndex}");


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] myArray = CreateRandomArray(5, -100, 100);
ShowArray(myArray);

int numMax = 0;

for (int i = 0; i < myArray.Length; i++) 
{
    if (myArray[i] < myArray[i+1])
    {
        numMax = myArray[i+1];
    } 
}
Console.WriteLine($"Максимальный элемент = {numMax}");

// цикл для минимума

//Console.WriteLine($"Разница между максимальным и минимальным эелементом = {numMax-numMin}");