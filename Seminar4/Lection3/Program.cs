// Типы методов

// Тип 1: ничего не принимает, ничего не возвращает

void Method1()
{
    Console.Write("Автор...");
}
Method1();


// Тип 2: ничего не принимает, но возвращает

void Method2(string msq)
{
    Console.WriteLine("Текст сообщения");
}
Method2("Текст сообщения"); // или Method2(msg: "Текст сообщения"); - именуем, если аргумент не один

// или другой пример:

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);

// Тип 3: ничего не принимает, но возвращает

int Method3()
{
    return DateTime.Now.Year;    
}
int year = Method3();
Console.WriteLine(year);

// Тип 4: и принимает и возвращает

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count);
    {
        result = result + c;
        i++;
    }   
    return result;
}
string res = Method4(10, "asdf");
Console.Write(res);