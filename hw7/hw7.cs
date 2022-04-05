void Print2DArray(int[,] myArray)
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


int[,] Create2DimArray(int hight, int length, int min, int max)
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
float[,] Create2DFloatArray(int hight, int length, int min, int max)
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

void Print2DFloatArray(float[,] myArray)
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
float[,] myFloatArray = Create2DFloatArray(3, 4, -10, 10);
Print2DFloatArray(myFloatArray);
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
        int colomnLength = someIntArray.GetLength(0);
       

        // найдем индексы нужного элемента в массиве
        int i = number / rowLength;
        // индекс элемента в конкретном ряду (колонка)
        number = number % rowLength;
        int j = rowLength - (rowLength - number) - 1;
        Console.WriteLine($"i={i}, j ={j}");
        

        return someIntArray[i, j];
    }
    // нужно вернуть число!
    // если ни чего не получилось,
    // то возвращаем число,
    // ктоторого точно не может быть в массиве.
    // например "-1" для массива положительных чисел.

    return -1;
}


int[,] myIntArray = Create2DimArray(hight:3, length: 5, min: 0, max:10);
Print2DArray(myIntArray);


int position = new Random().Next(0, myIntArray.Length);

int number = GetNumberFromPositionInArray(myIntArray, position);

String str50 = number >= 0
    ?
    $"На {position} позиции в массиве находится число = {number}"
    :
    $"позиция {position} за пределами массива";


Console.WriteLine(str50);
for (int i = 0; i < 20; i++)
{
    Console.WriteLine(GetNumberFromPositionInArray(myIntArray, i) + "; " + i);
}



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
