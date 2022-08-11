// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 != num2)
{
    if (num1 < num2)
    {
        Console.WriteLine("Первое число меньшее");
        Console.WriteLine("Второе число большее");
    }
    else
    {
        Console.WriteLine("Первое число большее");
        Console.WriteLine("Второе число меньшее");
    }
}
else
{
    Console.WriteLine("Числа равны");
}    