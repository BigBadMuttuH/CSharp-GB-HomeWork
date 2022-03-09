//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Пример
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
void isPalindrom(int num)
{
    int tmp = num;    
    int[] n = new int[5];
    for (int i = 0; i < n.Length; i++)
    {
        n[i] = num % 10;
        num = Math.Abs(num / 10);
    }
    if (n[0] == n[4] && n[1] == n[3])
        Console.WriteLine($"{tmp} - палиндром");
    else
        Console.WriteLine($"{tmp} - НЕ палиндром");
}
isPalindrom(14212);
isPalindrom(23432);
isPalindrom(12821);
Console.WriteLine("\n----------------------------------");

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B(2, 1, -7), -> 15.84
//A (7, -5, 0); B(1, -1, 9)-> 11.53
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
Console.WriteLine("\n----------------------------------");


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9.
//5 -> 1, 8, 27, 64, 125
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
void getCubeOfNumber(int num)
{
    Console.WriteLine($"Кубы числел до {num}\n");
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i}^3={ i * i *i}, ");
    }
    Console.WriteLine("\n----------------------------------");
}
getCubeOfNumber(3);
getCubeOfNumber(5);
getCubeOfNumber(8);
getCubeOfNumber(10);
Console.WriteLine("\n----------------------------------");
