// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int [] CreateArray ()
{
    Console.Write("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.Write($"Введите {i+1} элемент массива: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Array;
}

int[] myArray = CreateArray();
Console.WriteLine($"{String.Join(",", myArray)}");

int posElemCount = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        posElemCount += 1;
    }
}
Console.WriteLine($"В массиве {posElemCount} элемент(-а/-ов) больше 0");
