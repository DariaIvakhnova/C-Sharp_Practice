// Задача 17: Напишите программу, которая принимает на вход координаты
// точки (Х и Y), причем X и Y не равны 0, и выдает номер четверти плоскости,
// в которой находится эта точка.
//                         ^ у
//           x<0, y>0  (2) | (1)   x>0, y>0
//          ---------------|-----------------> х
//           x<0, y<0  (3) | (4)   x>0, y<0
//                         |

//Вариант 1. Через if else

//Console.WriteLine("Введите координаты x:");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите координаты y:");
//int y = Convert.ToInt32(Console.ReadLine());
//if (x>0 && y>0)
//{
//    Console.WriteLine("Первая четверть");
//}
//else if (x<0 && y>0)
//{
//    Console.WriteLine("Вторая четверть");
//}
//else if (x<0 && y<0)
//{
//    Console.WriteLine("Третья четверть");
//}
//else if (x>0 && y<0)
//{
//    Console.WriteLine("Четветрая четверть");
//}
//else
//{
//    Console.WriteLine("Определить четверть невозможно");
//}

//Вариант 2. Через функцию

void printQuarter(int x, int y) //переменные для работы внутри ф-ии лучше 
{                               //именовать по-другому, но значения их будут
    if (x>0 && y>0)             //такими же, как х и у
    {
        Console.WriteLine("Первая четверть"); 
    }                                          
    else if (x<0 && y>0)                      
    {
        Console.WriteLine("Вторая четверть");
    }
    else if (x<0 && y<0)
    {
        Console.WriteLine("Третья четверть");
    }
    else if (x>0 && y<0)
    {
        Console.WriteLine("Четветрая четверть");
    }
    else
    {
        Console.WriteLine("Определить четверть невозможно");
    }
}
Console.WriteLine("Введите координаты x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y:");
int y = Convert.ToInt32(Console.ReadLine());
printQuarter(x, y);

// Можно заменить void на int и Console.Write внутри на return 1; (номера четвертей).
// Тогда, чтобы увидеть результат работы функции, в последней строке меняем на
//Console.WriteLine(printQuarter(x, y));
//или Console.WriteLine($"Номер четверти - {printQuarter(x, y)}");

//Вариант 3. Через switch case

Console.Write("Введите координаты точки X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y: ");
int y = int.Parse(Console.ReadLine()!);
string mes = "";
switch (x, y)
{
case (>0, >0): mes = "1"; break; //можно вместо переменной сразу 
case (>0, <0): mes = "4"; break; //вписать console.write(...)
case (<0, >0): mes = "2"; break;
case (<0, <0): mes = "3"; break;
default : mes = "введите отличное от 0"; break;
}
Console.WriteLine(mes);


// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
// Попробовать проеобразовать в void

Console.Write("Введите номер четверти: ");
int quarter=int.Parse(Console.ReadLine());

switch (quarter)              
{
case 1:
{
Console.WriteLine("x>0 y>0");
break;
}
case 2:
{
Console.WriteLine("x<0 y>0");
break;
}
case 3:
{
Console.WriteLine("x<0 y<0");
break;
}
case 4:
{
Console.WriteLine("x>0 y<0");
break;
}

default:
{
Console.WriteLine("Введена неправильная четверть");
break;
}
}


//Задача 21: Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите Х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)); //нахождение гипотенузы 
Console.WriteLine($"d={d:f2}"); //f2 - округление до двух знаков после запятой

//Задача 22: Напишите программу, которая на вход принимает число (N) 
//и на выходе выдает таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25
//2 -> 1, 4


