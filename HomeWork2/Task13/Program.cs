﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
if (99 < num && num < 1000)  
{
    Console.WriteLine(num % 10); //Третья цифра - остаток от деления на 10 для трехзначного числа
}
if (num > 999)
{
    while (num > 999) //Цикл снижения разрядности для чисел четырехзначных и выше
    {
        num = num / 10;           
    }
    Console.Write(num % 10); //Остаток от деления на 10, когда число становится трехзначным
}
if (num < 100) // else здесь почему-то не срабатывает
{
    Console.Write("Третьей цифры нет");
}