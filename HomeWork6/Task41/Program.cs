// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

функция, которая записывает введеные пользователем числа в массив с размером М
как зациклить просьбу ввода числа?
 
for (int i = 0; i < size; i++)
{
  Console.WriteLine($"Введите {i+1} элемент массива");
  Array[i] = Convert.ToInt32(Console.ReadLine());
}
return Array;


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


//int[] myArray = CreateRandomArray(4, -100, 100);
// ShowArray(myArray);

// int posNum = 0;

// for (int i = 0; i < myArray.Length; i++) //первой нечетной позицией считаем индекс 1
// {
//    if (myArray[i] > 0)
            posNum += myArray[i]; || доделать
    }
// }

// Console.WriteLine($"Сумма элементов с нечетными индексами = {sumOddIndex}");






int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
