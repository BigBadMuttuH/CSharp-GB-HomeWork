void PrintArray(int[] myArray)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    Console.Write("[ ");
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]}");
        if (i == myArray.Length - 1)
        {
            Console.Write(" ]");
        }
        else
        {
            Console.Write(", ");
        }
    }
    Console.ForegroundColor = ConsoleColor.White;
}

// Задача 72:
// Заданы 2 массива: info и data.
// В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// входные данные:
// data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = { 2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

Console.WriteLine("data:");
PrintArray(data);
Console.WriteLine();

Console.WriteLine("info:");
PrintArray(info);
Console.WriteLine();


// получаем массив нужных элементов
// из массива intDataArray, выбирая по количеству элементов intInfoArray
// пошел простым путем, и сложил все в массив Sting-оф :(
// наверняка есть более простое решение, но я его пока не нашел.

String[] ParseDataFromArray(int[] intDataArray, int[] intInfoArray)
{
    string[] stringArray = new string[info.Length];

    // сдвиг по индексам массива info
    int counter = 0;

    for (int i = 0; i < intInfoArray.Length; i++)
    {
        for (int j = counter; j < counter + intInfoArray[i]; j++)
        {
            stringArray[i] += intDataArray[j];
        }
        counter += intInfoArray[i];
    }

    return stringArray;
}


int[] ConversionArrayToDec(string[] stringArray)
{
    int[] decimalArray = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        // преобразование строки в десятичный формат
        for (int j = 0; j < stringArray[i].Length; j++)
        {
            if (stringArray[i][stringArray[i].Length - j - 1] == '0')
            {
                continue;
            }
            decimalArray[i] += (int)Math.Pow(2, j);
        }
    }
    return decimalArray;
}


string[] bArray = ParseDataFromArray(data, info);
Console.WriteLine("Bin Array:");
foreach (var item in bArray)
{
    Console.Write($"{item}\t");
}
Console.WriteLine();

int[] intArray = ConversionArrayToDec(bArray);
Console.WriteLine("Decimal Array:");
PrintArray(intArray);
