// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool AntiRepeatCheck (int[] array, int element) // метод для проверки уникальности элемента массива
{
    bool check = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (element == array[i])
        {
            check = false;
        }
    }
    return check;
}

int lines = 2;
int columns = 2;
int cubes = 2;
Random rand = new Random();
int[,,] newMatrix = new int[lines,columns,cubes]; // заполнение трехмерного массива рандомными двухзначными числами
int[] array = new int[lines*columns*cubes]; // создание одном.массива размером равным количеству элементов трехм. массива, куда записываются элементы трехм.массива
int n = 0;
for (int i = 0; i < newMatrix.GetLength(0); i++)  
{
    for (int j = 0; j < newMatrix.GetLength(1); j++) 
    {
        for (int k = 0; k < newMatrix.GetLength(2); k++)   
        {
            newMatrix[i, j, k] = rand.Next(10,100);
            while(AntiRepeatCheck(array, newMatrix[i,j,k]) == false) //проверка на уникальность сгенерированного элемента
            {
                newMatrix[i,j,k] = rand.Next(10,100); //если число не уникально (false) - генерируем новое и снова проверяем
            }
            array[n] = newMatrix[i,j,k]; //если true - записываем число в одном.массив
            n++;
            Console.Write($"{newMatrix[i, j, k]} ({j},{k},{i})\t"); //вывод элементов трехм. массива
        }
        Console.WriteLine();
    }
}
