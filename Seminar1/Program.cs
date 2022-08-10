// Задача №1. Напишите программу, которая на вход принимает число 
// и выдает его квадрат (число, умноженное само на себя)

// Console.Clear();

//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//Далее три различных метода возведения в квадрат

// int sqrt = number * number;

// number *= number;

// Console.Write("Число в квадрате: " + number);

//int sqrt = Convert.ToInt32(Math.Pow(number, 2));
//Console.Write("Число в квадрате: " + sqrt);

//Задача №2. Напишите программу, которая на вход принимает два числа
//и проверяет, является ли первое число квадратом второго.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
    Console.Write("First number is a square of second number");
else
    Console.Write("First number is not a square of second number");

//Задача №3. Напишите программу, которая будет выдавать значение
// дня недели по заданному номеру.

//Console.Write("Input number of the day: ");

//int day = Convert.ToInt32(Console.ReadLine());

//if (day < 1 || day > 7)
//{
//    Console.Write("Incorrect number");
//}
//else
//{
//    if (day == 1)
//    {
//    Console.Write("Monday");
//    }
//    if (day == 2)
//    {
//    Console.Write("Tuesday");
//    }
//    if (day == 3)
//    {
//    Console.Write("Wednesday");
//    }
//    if (day == 4)
//    {
//    Console.Write("Thursday");
//    }
//    if (day == 5)
//    {
//    Console.Write("Friday");
//    }
//    if (day == 6)
//    {
//    Console.Write("Saturday");
//    }
//    if (day == 7)
//    {
//    Console.Write("Sunday");
//    }
//}
