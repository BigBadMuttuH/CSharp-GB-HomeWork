// num1 до 50, только для того, чтобы подошло по всем условиям
// num2 до 7, - по количеству дней недели и для поиска квадрата 

int num1 = new Random().Next(1,50);
int num2 = new Random().Next(1, 7);

//- Показать числа от -N до N
Console.WriteLine($"Показать числа от -{num1} до {num1}");
void printAllintNumbers(int num)
{
    for (int i = -num; i <= num; i++)
    {
        Console.Write($"{i} ");
    }
}
printAllintNumbers(num1);
Console.WriteLine("\n----------------------");




//- Показать четные числа от 1 до N
Console.WriteLine($"Показать четные числа от 1 до {num1}");
void printEvenNumbers(int num)
{
    for (int i = 0; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
    }
}
printEvenNumbers(num1);
Console.WriteLine("\n----------------------");




//- Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine($"Дано число {num2}, обозначающее день недели.");
Console.WriteLine("Выяснить является номер дня недели выходным ");
void printDayOff(int num)
{
    if (num > 5)
        Console.WriteLine($"{num} - выходной");
    else
        Console.WriteLine($"{num} - это не выходной день :(");
}
printDayOff(num2);
Console.WriteLine("\n----------------------");

// - По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine($"По двум заданным числам {num1} и {num2}");
Console.WriteLine($"проверять является ли {num1} квадратом {num2}.");
void isSqrtOffNumber(int num1, int num2)
{
    if (num1 == num2 * num2)
        Console.WriteLine($"число {num1} является квадратом {num2}");
    else
        Console.WriteLine($"число {num1} НЕ является квадратом {num2}");
}
isSqrtOffNumber(num1, num2);
Console.WriteLine("----------------------");
// просто проверка
isSqrtOffNumber(16, 4);
isSqrtOffNumber(49, 7);
Console.WriteLine("\n----------------------");




// Определить номер четверти плоскости,
// в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// пускай точка с координатами X,Y будет массивом.
void getNumberOfQaurterPlane()
{
    int[] ord = new int[2];
    int tmp; // для проверки что не 0
    int i = 0;
    do
    {
        tmp = new Random().Next(-10, 15);
        if (tmp != 0)
        {
            ord[i] = tmp;
            i++;
        }
        //Console.WriteLine("tmp=" + tmp + " i=" + i);
    }
    while (i < ord.Length);

    Console.WriteLine($"Определить номер четверти плоскости,");
    Console.WriteLine($"в которой находится точка с координатами: X={ord[0]} и Y={ord[1]}");

    if (ord[0] > 0 && ord[1] > 0)
        Console.WriteLine("это I четверть");
    else if (ord[0] < 0 && ord[1] > 0)
        Console.WriteLine("это II четверть");
    else if (ord[0] < 0 && ord[1] < 0)
        Console.WriteLine("это III четверть");
    else
        Console.WriteLine("это IV четверть");
}
getNumberOfQaurterPlane();
Console.WriteLine("\n----------------------");



// Найти расстояние между точками в пространстве 2D/3D
// создадим две трехмерные точки. для нахождения в расстояния между ними в 2D
// просто не будем учитывать их координаты по оси Z
void getPointRange()
{


    int[] a = new int[3];
    int[] b = new int[3];
    double range = 0;

    for (int i = 0; i < 3; i++)
    {
        a[i] = new Random().Next(-50, 50);
        b[i] = new Random().Next(-50, 50);
    }
    Console.WriteLine(" Найти расстояние между точками в пространстве 2D/3D ");
    Console.WriteLine($"a[X={a[0]},Y={a[1]},Z={a[2]}], b[X={b[0]},Y={b[1]},Z={b[2]}]");

    // 2D
    range = Math.Sqrt(Math.Pow(b[0] - a[0], 2)
        + Math.Pow(b[1] - a[1], 2));

    Console.WriteLine("В 2D = {0:f2}", range);

    range = Math.Sqrt(Math.Pow(b[0] - a[0], 2)
        + Math.Pow(b[1] - a[1], 2)
        + Math.Pow(b[2] - a[2], 2));
    Console.WriteLine("В 3D = {0:f2}", range);

}
getPointRange();



//Задание
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Пример
//456 -> 5
//782 -> 8
//918 -> 1
int getSecondNumber(int num)
{
    int number = System.Math.Abs(num / 10 % 10);
    return number;
}
Console.WriteLine(getSecondNumber(456));
Console.WriteLine("----------------------");
Console.WriteLine(getSecondNumber(782));
Console.WriteLine("----------------------");
Console.WriteLine(getSecondNumber(981));
Console.WriteLine("----------------------");



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
void getThirdNumber(int num)
{
    int number = 0;
    int tmp = num; // только для кравивого вывода

    if (num < 100)
        Console.WriteLine($"{num} двухзначное число");
    else
    {
        while (num > 100)
        {
            number = num % 10;
            num = System.Math.Abs(num / 10);
        }
        Console.WriteLine($"Третья цифра числа {tmp} = {number}");
    }
}
getThirdNumber(645);
getThirdNumber(78);
getThirdNumber(32679);
getThirdNumber(100);
Console.WriteLine("\n----------------------");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");
printDayOff(6);
printDayOff(7);
printDayOff(1);