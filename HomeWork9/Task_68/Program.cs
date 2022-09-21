// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


int Accerman(int m, int n) // метод для вычисления функции Аккермана
{
    if (n == 0) 
    {
        return m + 1;
    }    
    if (n > 0 && m == 0) 
    {
        return Accerman(1, n - 1);
    }
    return Accerman(Accerman(m - 1, n), n - 1);
}

int numberM;
int numberN;
do {    // цикл для отсечения ввода отрицательных чисел
    Console.Clear();
    Console.WriteLine("Введите неотрицательные числа.");
    Console.Write("Введите M: ");
    Int32.TryParse((Console.ReadLine()!), out numberM);
    Console.Write("Введите N: ");
    Int32.TryParse((Console.ReadLine()!), out numberN);
} while (numberM < 0 || numberN < 0);

Console.WriteLine($"Результат вычисления функции Аккермана = {Accerman(numberM, numberN)}");