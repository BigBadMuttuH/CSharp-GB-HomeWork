void Print2DArray(int[,] int2DArray)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    for (int i = 0; i < int2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int2DArray.GetLength(1); j++)
        {
            //Console.Write($"{i},{j} {int2DArray[i, j]}\t");
            Console.Write($"{int2DArray[i, j]}\t");

        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

int[,] Create2DimArray(int hight, int length, int min, int max)
{
    int[,] int2DArray = new int[hight, length];

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < length; j++)
        {
            int2DArray[i, j] = new Random().Next(min, max);
        }
    }

    return int2DArray;
}


//-Задача 57:
// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
Console.WriteLine("Задача 57: Составить частотный словарь элементов двумерного массива");

// вспомогательный метод, проверяет если элемент в массиве
bool isInArray(int value, int[,] int2DArray)
{
    foreach (int item in int2DArray)
    {
        if (item == value) return true;
    }
    return false;
}

// вспомогательный метод, считаем сколько элементов в массиве
int countArrayElement(int value, int[,]int2DArray)
{
    int counter = 0;
    foreach (int item in int2DArray)
    {
        if (value == item) counter++;
    }
    return counter;
}


int[,] GetFrequencyArray(int[,] int2DArray)
{
    int[,] frequencyArray = new int[int2DArray.Length, 2];
    int element = 0;

    // для проверки, если в исходном массиве появиться "0"
    int zeroElement = 0;

    foreach (int item in int2DArray)
    {
        // изначально frequencyArray состоит из 0, поэтому исключаем еще и "item = 0"
        // обработаем их дальше в else if
        if (!isInArray(item, frequencyArray) && item != 0)
        {
            frequencyArray[element, 0] = item;
            frequencyArray[element, 1] = countArrayElement(item, int2DArray);
        }
        else if(item == 0 && zeroElement == 0)
        {
            frequencyArray[element, 1] = countArrayElement(item, int2DArray);
            zeroElement++;
        }
        element++;
    }

    return frequencyArray;
}

// вывод частотного массива на консоль
void PrintFrequencyArray(int[,] frequencyArray)
{
    for (int i = 0; i < frequencyArray.GetLength(0); i++)
    {
        if(frequencyArray[i,1] != 0)
            Console.WriteLine($"{frequencyArray[i,0]} встречается {frequencyArray[i,1]} раз");
    }
}

int[,] myArray = Create2DimArray(3, 5, -2, 3);
Print2DArray(myArray);
int[,] myFrArray = GetFrequencyArray(myArray);
PrintFrequencyArray(myFrArray);

Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
Console.ReadKey();
Console.Clear();


//- Задача 61:
//Вывести первые N строк треугольника Паскаля.
//Сделать вывод в виде равнобедренного треугольника
Console.WriteLine("Задача 61: Вывести первые N строк треугольника Паскаля");
Console.Write("Введите количество строк: ");
int[][] CreatePascalsTriangle(int rows)
{
    int colomns = 0;
    int[][] pascalsTriangleArray = new int[rows][];
    for (int i = 0; i < rows; i++)
    {
        colomns = 1 * (i + 1);
        pascalsTriangleArray[i] = new int[colomns];
        for (int j = 0; j < colomns; j++)
        {
            pascalsTriangleArray[i][j] = 1;
            if (j > 0 && j < pascalsTriangleArray[i].Length - 1)
            {
                pascalsTriangleArray[i][j] = pascalsTriangleArray[i - 1][j - 1]
                                             + pascalsTriangleArray[i - 1][j];
            }

            // с выводом на консоль так себе получилось. :(
            if (j == 0)
            {
                Console.Write($"{new string(' ', rows - i)}" +
                            $" {pascalsTriangleArray[i][j]} ");
            }
            else
            {
                Console.Write($" {pascalsTriangleArray[i][j]} ");
            }
        }
        Console.WriteLine();
    }


    return pascalsTriangleArray;
}
int rows = int.Parse(Console.ReadLine());
CreatePascalsTriangle(rows);
Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
Console.ReadKey();
Console.Clear();




//- Задача 54:
//Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine(" Задача 54: Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива");

int[,] myArray54 = Create2DimArray(4, 5, 10, 100);
Print2DArray(myArray54);


int[,] Sort2DArray(int[,] int2DArray)
{
    int tmp = 0;

    for (int i = 0; i < int2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int2DArray.GetLength(1); j++)
        {
            for (int k = 0; k < int2DArray.GetLength(1); k++)
            {
                if (int2DArray[i, j] <= int2DArray[i, k]) continue;

                tmp = int2DArray[i, j];
                int2DArray[i, j] = int2DArray[i, k];
                int2DArray[i, k] = tmp;
            }
        }
    }
    return int2DArray;
}
Console.WriteLine();
Sort2DArray(myArray54);

Console.WriteLine("Упорядоченный массив");
Print2DArray(myArray54);

Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
Console.ReadKey();
Console.Clear();


//- Задача 56:
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine(" Задача 56: Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
int[,] myArray56 = Create2DimArray(3, 5, -1, 10);
Print2DArray(myArray56);
int GetMinSumOfRow(int[,] int2DArray)
{
    int[] sumRow = new int[int2DArray.GetLength(0)];

    for (int i = 0; i < int2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int2DArray.GetLength(1); j++)
        {
            sumRow[i] += int2DArray[i, j];
        }
        Console.WriteLine($"Сумма чисел в {i + 1}-строке = {sumRow[i]}");
    }
    
    int sum = sumRow[0];
    int minRoeIndex = 0;

    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[i] < sum)
        {
            sum = sumRow[i];
            minRoeIndex = i;
        }
    }
    // есть проблема, если строк, с минимальной суммой будет несколько :(
    // тогда посчитает только первую строку.
    return minRoeIndex + 1;
}
int rowIndex = GetMinSumOfRow(myArray56);
Console.WriteLine($"Наименьшая сумма чисел в строке - {rowIndex}");



Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
Console.ReadKey();
Console.Clear();



//- Задача 58:
//Задайте две матрицы.
//Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Задача 58: Напишите программу, которая будет находить произведение двух матриц");
int[,] aMatrix = Create2DimArray(3, 2, 1, 5);
Console.WriteLine("матрицы A:");
Print2DArray(aMatrix);
Console.WriteLine();

int[,] bMatrix = Create2DimArray(2, 4, 5, 10);
Console.WriteLine("матрицы B:");
Print2DArray(bMatrix);
Console.WriteLine();


int[,] Multiply2Matrix(int[,] aMatrix, int[,] bMatrix)
{

    int row = (aMatrix.GetLength(0) >= bMatrix.GetLength(0)) ? aMatrix.GetLength(0) : bMatrix.GetLength(0);
    int col = (aMatrix.GetLength(1) >= bMatrix.GetLength(1)) ? aMatrix.GetLength(1) : bMatrix.GetLength(1);

    int[,] multiplyMatrix = new int[row, col];

    // Матрицу A можно умножить на матрицу B только в том случае,
    // если число столбцов матрицы A равняется числу строк матрицы B.
    // Матрицы, для которых данное условие не выполняется, умножать нельзя.


    if (aMatrix.GetLength(1) == bMatrix.GetLength(0))
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                for (int k = 0; k < bMatrix.GetLength(0); k++)
                {
                    multiplyMatrix[i, j] += aMatrix[i, k] * bMatrix[k, j];
                }
            }
        }

        return multiplyMatrix;
    }
    else
    {
        Console.WriteLine("Не возможно умножить матрицу А на В");
        Console.WriteLine($"Нужно чтобы число столбцов матрицы А ({aMatrix.GetLength(1)}) было рано числу столбцы матрицы B ({bMatrix.GetLength(0)})");
        return multiplyMatrix;
    }
}
int[,] mMatrix = Multiply2Matrix(aMatrix, bMatrix);
Console.WriteLine("Произведение матрицы А на B:");
Print2DArray(mMatrix);

Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
Console.ReadKey();
Console.Clear();



//- Задача 60:
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел");
int GetUniqNumber(int[] intArray)
{
    int nextNumber;
    do
    {
        nextNumber = new Random().Next(10, 100);
    }
    while (intArray[nextNumber] != 0);
    intArray[nextNumber] = 1;
    return nextNumber;
}
int[,,] Generate3DArray(int rows, int columns, int layers, int[] intArray)
{
    int[,,] returnArray = new int[rows, columns, layers];

    if (rows * columns * layers < 90)
    {
        for (int i = 0; i < returnArray.GetLength(0); i++)
        {
            for (int j = 0; j < returnArray.GetLength(1); j++)
            {
                for (int k = 0; k < returnArray.GetLength(2); k++)
                {
                    returnArray[i, j, k] = GetUniqNumber(intArray);
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Слишком большой массив для уникальных двухзначных чисел");
    }
    return returnArray;

}
void Print3DArray(int[,,] int3DArray)
{
    for (int i = 0; i < int3DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int3DArray.GetLength(1); j++)
        {
            for (int k = 0; k < int3DArray.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {int3DArray[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[] intArray = new int[100];
int[,,] array3D = Generate3DArray(3, 3, 3, intArray);
Print3DArray(array3D);
System.Console.WriteLine();

Console.WriteLine("Нажмите любую клавиру, чтобы продолжить");
Console.ReadKey();
Console.Clear();


//-Задача 62:
//Заполните спирально массив 4 на 4. 
Console.WriteLine("Задача 62: Заполните спирально массив");

int[,] PrintSpiral2DArray(int height, int length)
{
    int[,] spiralArray = new int[height, length];

    int i = 0;
    int j = 0;

    int xDirection = 1, yDirection = 0;
    int direction = 0, sideLength = length;

    for (int item = 0; item < spiralArray.Length; item++)
    {
        spiralArray[i, j] = item + 1;

        --sideLength;
        if (sideLength == 0)
        {
            // расчет длины стороны по которой приходимся в данный момент
            // выбор по какой стороне сейчас идем
            sideLength = length * (direction % 2) + height * ((direction + 1) % 2)
                // поправка по длине 
                - (direction/2 - 1) - 2;


            int temp = xDirection;
            xDirection = -yDirection;
            yDirection = temp;
            direction++;
        }
        i += yDirection;
        j += xDirection;
    }

    return spiralArray;
}

int[,] myArray62 = PrintSpiral2DArray(10,10);
Print2DArray(myArray62);
