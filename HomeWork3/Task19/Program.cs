// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Console.ReadLine();
if (number < 10000 || 99999 < number)
{
	Console.Write("Число введено некорректно"); 
	break; 
	Console.Write(dotnet run);
}

int firstDigit = Convert.ToInt32(number/1000) //рассматривать сразу двухзначное число
int secondDigit = Convert.ToInt32(number/100) //
int fourthDigit = Convert.ToInt32(number%100)
int fifthDigit = Convert.ToInt32(number%10)

int temp = fourthDigit;
fourthDigit = fifthDigit;
fifthDigit = temp;

if (firstDigit*10+secondDigit == fourthDigit*10+fifthDigit);
{
	Console.Write($"{number} является палиндромом");
}
else Console.Write($"{number} не является палиндромом");
