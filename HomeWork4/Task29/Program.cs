// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();
Console.Write("Введите размер массива: "); // Решила сделать пользвательский ввод, 
int size = Convert.ToInt32(Console.ReadLine()); // чтобы внутри не было "магического" числа
int[] myArray = new int[size];
Random rnd = new Random();
Console.Write ("Массив: ");
for (int i = 0; i < size; i++)
{
    myArray[i] = rnd.Next();
    Console.Write(myArray[i] + ", ");
}    

// Собрать красивый вывод массива так и не получилось, возможно нужен какой-то метод