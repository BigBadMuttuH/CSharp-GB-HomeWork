// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] CreateArrayFromConsole(int number)
{
    int[] intArray = new int[number];
    Console.WriteLine($"введите {number} целых чисел:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"все ошибки ввода будут заменены на 0");
    Console.ForegroundColor = ConsoleColor.White;

    for (int i = 0; i < intArray.Length; i++)
    {
        bool success = int.TryParse(Console.ReadLine(), out int num);
        intArray[i] = success ? num : 0;
    }

    return intArray;
}

int GetPositiveNumbersCount(int[] intArray)
{
    // совместим проход по массиву с его выводом на конслоль.
    int counter = 0;
    foreach (int item in intArray)
    {
        if (item > 0) counter++;
        Console.Write($"{item} ");
    }

    return counter;
}

int[] intArray = CreateArrayFromConsole(10);
int counter = GetPositiveNumbersCount(intArray);

Console.WriteLine("\n");
Console.WriteLine($"количество чисел больше 0 = {counter}");
Console.WriteLine("\n");


// Задача 43.
// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// x(k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

String GetPointOfIntersection(int k1, int k2, int b1, int b2)
{
    string str43 = "Найти точку пересечения двух прямых:";
    Console.WriteLine(str43); 
    Console.WriteLine($"y = {k1}*x + {b1}");
    Console.WriteLine($"y = {k2}*x + {b2}");

    if (k1 - k2 != 0)
    {
        float x = (float)(b2 - b1) / (float)(k1 - k2);
        float y = k1 * x + b1;

        return $"точка пересечения ({x:f1} ; {y:f1})";
    }
    else
    {
        return "прямые не пересекаются или совпадают";
    }
}

int b1 = 2, // y = k1 * x + b1
    k1 = 5,
    b2 = 4, // y = k2 * x + b2
    k2 = 9;
Console.WriteLine(GetPointOfIntersection(k1, k2, b1, b2));