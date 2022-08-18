// 25

Console.WriteLine("Enter a number: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("And its power: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
numB = Math.Abs(numB);
int firstA = numA;
int i = 0;

//Console.WriteLine($"{numA} raised to a power {numB} = {Math.Pow(numA, numB)}");

if (numA == 0)
{
    Console.WriteLine($"{firstA} raised to a power {numB} = {numA}");    
}

else 
{
    while (i < numB) 
    {
        numA *= firstA;
        i++;
    }
    numA /= firstA;
    Console.WriteLine($"{firstA} raised to a power {numB} = {numA}");
}

//

Console.Write("Введите A: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int number2 = int.Parse(Console.ReadLine());

int num = Convert.ToInt32(Math.Pow(number1, number2));
Console.WriteLine(num);

//

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
char[] array = Math.Abs(num).ToString().ToCharArray();
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    int convert = int.Parse(array[i].ToString());  // int convert = array[i] - '0'; - второй вариант  
    sum = sum + convert;
}
Console.Write($"Сумма цифр в числе {num} = {sum}");

//

Console.Clear();
Console.WriteLine("Input random number: ");
double num = Convert.ToDouble(Console.ReadLine()!);
double sum = 0;
num = Math.Abs(num);
while(num > 0)
{

    sum += num%10;
    num = Math.Floor(num/10);     
}
Console.Write($"The sum of the digits in a number: {Math.Floor(sum)}");

//

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

//

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);
ShowArray(myRandomArray);
Console.WriteLine("-------");
int[] myArray = CreateArray();
ShowArray(myArray);

// 29

Console.Clear();
int[] array = GetRandomArray(8,0,100);
Console.WriteLine($"[{String.Join(", ", array)}]");


int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue);
    }

    return result;
}

//

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

int sum_pos = 0;
int sum_neg = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
        sum_pos += myArray[i];
    else
        sum_neg += myArray[i];
}

Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

// задача 32

Console.Clear();

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] moyarray = CreateRandomArray(8,-10,11);
Console.WriteLine(String.Join(",",moyarray));
for (int i = 0; i < moyarray.Length; i++)
{
    moyarray[i]=-moyarray[i];
}
Console.WriteLine(String.Join(",",moyarray));

// задача 33

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input size: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Input min: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Input max: ");
int max = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Input random number: ");
int random = int.Parse(Console.ReadLine() ?? "0");
bool flag = false;
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == random)
    {
        flag = true;
    }
}
if (flag == true)
{
    Console.WriteLine($"Данное число  присутствует в массиве: " + random);

}
else
{
    Console.WriteLine("Не присутствует");
}

// задача 35

// ранее описанная функция + 

int[] myArray = CreateRandomArray(123, 0, 200);
ShowArray(myArray);
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] >= 10 && myArray[i] <= 99)
    {
        Console.Write($"{myArray[i]}"+ "|");
    }
    else
    Console.Write("-");
}

// 37

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

int result = 0;
int a = myArray.Length -1;
for (int i = 0; i < myArray.Length/2 ; i++)
{
    result = myArray[i] * myArray[a];
    a -= 1;
    Console.Write($"[{String.Join(",", result)}]");
}
if(myArray.Length%2 != 0)
{
    Console.Write($"[{String.Join(",", myArray[myArray.Length/2])}]");
}

// округление 
// Math.Round(num / 10000, 
// MidpointRounding.ToZero
