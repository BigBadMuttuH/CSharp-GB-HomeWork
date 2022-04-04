﻿void PrintTowDimintArray(int[,] myArray)
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
float[,] myFloatArray = CreateTowDimentionFloatArray(3, 4, -10, 10);
PrintTowDimFloatArray(myFloatArray);
Console.WriteLine();


// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int GetNumberFromPositionInArray(int[,] someIntArray, int number)
{
    int position = number;

    if ( number > 0 && number <= someIntArray.Length)
    {
        int rowLength = someIntArray.GetLength(1);
        
        // найдем индексы нужного элемента в массиве
        int i = 0, j = 0;
        // строка (row ряд) в котором находиься нужный элемент
        while (number > rowLength)
        {
            number -= rowLength;
            i++;
        }
        // индеск элемента в конкретном ряду (колонка)
        j = rowLength - ( rowLength - number ) - 1;

        return someIntArray[i, j];
    }
    // нужно вернуть число!
    // если ни чего не получилось,
    // то возвращем число,
    // ктоторого точно не може быть в массиве.
    // например "-1" для массива положительных чисел.

    return -1;
}


int[,] myIntArray = CreateTowDimArray(hight:3, length: 5, min: 0, max:10);
PrintTowDimintArray(myIntArray);

int position = new Random().Next(0, myIntArray.Length);

int number = GetNumberFromPositionInArray(myIntArray, position);

String str50 = number >= 0
    ?
    $"На {position} позиции в массиве находится число = {number}"
    :
    $"позиция {position} за пределами массива";

Console.WriteLine(str50);



// Задача 52:
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
float[] GetAverage(int[,] intArray)
{
    float[] avarageArray = new float[intArray.GetLength(1)];
    float sum = 0;

    int rows = intArray.GetLength(0);
    int columns = intArray.GetLength(1);
    
    // Console.WriteLine("rows {0}, columns={1}", rows, columns);
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum += intArray[i, j];
        }
        avarageArray[j] = sum / rows;
        sum = 0;
    }
    return avarageArray;
}
float[] avarageArray = GetAverage(myIntArray);

Console.WriteLine("Среднее арифметическое каждого столбца:");

Console.ForegroundColor = ConsoleColor.Red;

foreach (var item in avarageArray)
{
    Console.Write($"{item:f1}\t");
}    

Console.ForegroundColor = ConsoleColor.White;
