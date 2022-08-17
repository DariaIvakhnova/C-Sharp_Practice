// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count < number)
{
    int cubed = Convert.ToInt32(Math.Pow(count,3));
    Console.Write($"{cubed}, ");
    count++;
}
if (count == number) // чтобы после последнего числа не висела запятая
{
    int cubed = Convert.ToInt32(Math.Pow(count,3));
    Console.Write($"{cubed}");
}