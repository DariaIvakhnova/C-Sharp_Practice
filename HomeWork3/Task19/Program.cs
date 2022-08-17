// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstTwoDigits = Convert.ToInt32(number / 1000);
int fourthDigit = Convert.ToInt32((number / 10) % 10);
int fifthDigit = Convert.ToInt32(number % 10);
if (9999 < number && number < 100000)
{
    int temp = fourthDigit; // обмен значениями переменных (4-й и 5-й цифры)
    fourthDigit = fifthDigit;
    fifthDigit = temp;
    
    if (firstTwoDigits == fourthDigit * 10 + fifthDigit)
    {
        Console.Write($"{number} является палиндромом");
    }
    else
    {    
        Console.Write($"{number} не является палиндромом");
    }
}    
else
{
    Console.Write("Введено некорректное число");
}
