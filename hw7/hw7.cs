void PrintTowDimFloatArray(float[,] myArray)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write($"{myArray[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

void PrintTowDimintArray(int[,] myArray)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write($"{myArray[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

float[,] CreateTowDimentionFloatArray(int hight, int length, int min, int max)
{
    float[,] towDimFloatArray = new float[hight, length];

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < length; j++)
        {
            towDimFloatArray[i, j] = new Random().Next(min, max);
            towDimFloatArray[i, j] *= new Random().NextSingle();

        }
    }

    return towDimFloatArray;
}

int[,] CreateTowDimArray(int hight, int length, int min, int max)
{
    int[,] myTowDimArray = new int[hight, length];

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < length; j++)
        {
            myTowDimArray[i, j] = new Random().Next(min, max);
        }
    }

    return myTowDimArray;
}

// Задача 47:
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
float[,] myFloatArray = CreateTowDimentionFloatArray(3, 4, -10, 10);
PrintTowDimFloatArray(myFloatArray);
Console.WriteLine();


// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
String isNumberPositionInArrat(int[,] someIntArray, int number)
{
    int position = number;

    if ( number > 0 && number <= someIntArray.Length)
    {
        int row = someIntArray.GetLength(1);
        int col = someIntArray.GetLength(0);
        
        // найдем индексы нужного элемента в массиве
        int i = 0, j = 0;
        // строка (row) ряд в котором находиься нужный элемент
        while (number > row)
        {
            number -= row;
            i++;
        }
        // индеск элемента в конкретном ряду
        j = row - ( row - number ) - 1;

        return $"На {position} позиции в массиве находится число = {someIntArray[i, j]}";
    }
    return $"позиция {position} за пределами массива";
}


int[,] myIntArray = CreateTowDimArray(hight:5, length: 4, min: 100, max:999);
PrintTowDimintArray(myIntArray);

int position = new Random().Next(0, myIntArray.Length);
String str50 = isNumberPositionInArrat(myIntArray, position);
Console.WriteLine(str50);

// для тестирования вывода из задачи 50
//foreach (int item in Enumerable.Range(0, 13))
//{
//    Console.WriteLine(isNumberPositionInArrat(myIntArray, item));
//}




// Задача 52:
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.``
String GetAverage(int[,] intArray)
{
    String str = String.Empty;
    int sum = 0;
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            sum += intArray[i, j];
        }
        str += $"{sum}; \t";
        sum = 0;
    }
    return str;
}
String str52 = GetAverage(myIntArray);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
Console.WriteLine(str52);