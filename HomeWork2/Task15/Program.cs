// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (1 <= num && num < 8)
{
    if (num == 6 || num == 7)
    {
        Console.Write(num + " -> выходной день");
    }
    else
    {
        Console.Write(num + " -> будний день");
    }
}
else 
{
    Console.Write("Введеная цифра некорректна");
}
