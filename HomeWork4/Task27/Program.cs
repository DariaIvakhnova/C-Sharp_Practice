// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigits = 0;
while (number > 0)
{
    sumDigits = sumDigits + (number%10);
    number = number / 10;
}
Console.Write($"Сумма цифр равна {sumDigits}");