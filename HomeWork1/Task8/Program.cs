// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Программа отображает все четные числа от 1 до заданного числа.");
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 2; // Первое четное число
int B = 0; // Первое четное число для отрицательных чисел
if (N > 0)
{
while (A <= N)
    {
    Console.Write(A + " ");
    A = A+2;
    }
}    
else // Далее получилась довольно странная и громоздкая конструкция
{    // на случай ввода отрицательного числа, поскольку я использовала 
    if (N % 2 == 0) // пока только то, что знаю
    while (N <= B)
    {
        Console.Write(N + " ");
        N = N+2;
    }
    else
    {
       N = N+1;
       while (N <= B)
        {
            Console.Write(N + " ");
            N = N+2;
        }
    }
}