// массив интов
int[] CreateArray(int length, int min, int max)
{
    int[] myArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        myArray[i] = new Random().Next(min, max);
    }

    return myArray;
}

// массив вещественных чисел.
float[] CreateRealArray(int length, int min, int max)
{
    float[] myArray = new float[length];

    int multiplier = 0;

    for (int i = 0; i < length; i++)
    {
        multiplier = new Random().Next(min, max);

        myArray[i] = new Random().NextSingle() * multiplier;
    }

    return myArray;
}

// вывод любого массива
void PrintArray(Array myArray)
{
    Console.ForegroundColor = ConsoleColor.White;
    System.Console.Write("array: ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    Console.Write("[ ");

    int counter = myArray.Length;

    foreach (var n in myArray)
    {
        Console.Write($"{n}");
        counter--;

        if (counter > 0)
            Console.Write(", ");
    }
    Console.Write(" ]");
    Console.ForegroundColor = ConsoleColor.White;
}


//Задача 34:
//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int GetEvenNumbersInArray(int[] givenArray)
{
    int counter = 0;
    for (int i = 0; i < givenArray.Length; i++)
    {
        if (givenArray[i] % 2 == 0)
        {
            counter++;
        }
    }

    return counter;
}

int[] myArray1 = CreateArray(4, 100, 999);
int evenCount = GetEvenNumbersInArray(myArray1);
PrintArray(myArray1);
Console.Write($" Even numbers in array -> {evenCount}");

Console.WriteLine("\n");

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

int GetSumOfEventNumbers(int[] givenArray)
{
    int sum = 0;
    // первый четный элемент массива будет с индексом 1
    int i = 1;
    while (i < givenArray.Length)
    {
        sum += givenArray[i];
        i += 2;
    }

    return sum;
}

int[] myArray2 = CreateArray(8, -10, 10);
int evenSumCount = GetSumOfEventNumbers(myArray2);
PrintArray(myArray2);
Console.Write($" Sum of even numbers in array = {evenSumCount}");

Console.WriteLine("\n");


//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76
float getDifference(float[] givenArray)
{
    float min = givenArray[0];
    float max = givenArray[0];

    foreach (var item in givenArray)
    {
        if (item > max) max = item;
        if (item < min) min = item;
        //Console.WriteLine("item = {0}, min={1}, max={2}", item, min, max);
    }

    return max - min;
}


float[] myArray3 = CreateRealArray(5, -100, 100);
PrintArray(myArray3);
//Console.WriteLine();
float diff = getDifference(myArray3);
Console.WriteLine(" max - min = {0}", diff);

Console.WriteLine("\n");
