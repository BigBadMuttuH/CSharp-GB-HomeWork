int twoDigitNum = new Random().Next(10,99);
int threeDigitNum = new Random().Next(100,999);
int num = new Random().Next(1,999);


//- Вывести квадрат числа
Console.WriteLine($"Вывести квадрат числа {num}");
int getSquare(int num)
{
    num = num * num;
    return num;
}
Console.WriteLine(getSquare(num));
Console.WriteLine("----------------------");


//- Найти максимальное из трех чисел
Console.WriteLine($"Найти максимальное из трех чисел {num},{twoDigitNum},{threeDigitNum}");
int getMaximum(int a, int b, int c)
{
    int max = a;
    if (b > c && max < b) max = b;
    else if (c > b && max < c) max = c;
    Console.WriteLine($"{a}, {b}, {c} -> max {max}");
    return max;
}
Console.WriteLine(getMaximum(num, threeDigitNum, twoDigitNum));
Console.WriteLine("----------------------");



//- Выяснить является ли число чётным
Console.WriteLine($"Выяснить является ли число {threeDigitNum} чётным");
bool isEvenNumber(int number)
{
    bool isEvenNumber = number % 2 == 0;
    //Console.WriteLine("число{0} четное? {1}", number, isEvenNumber);
    return isEvenNumber;
}
Console.WriteLine(isEvenNumber(threeDigitNum));
Console.WriteLine("----------------------");



//- Показать последнюю цифру трёхзначного числа
Console.WriteLine($"Показать последнюю цифру трёхзначного числа {threeDigitNum}");
int getLastNumber(int num)
{
    int number = num % 10;
    return number;
}
Console.WriteLine(getLastNumber(threeDigitNum));
Console.WriteLine("----------------------");




//- Показать вторую цифру трёхзначного числа
Console.WriteLine($"Показать вторую цифру трёхзначного числа {threeDigitNum}");
int getSecondNumber(int num)
{
    int number = System.Math.Abs(num / 10 % 10);
    return number;
}
Console.WriteLine(getSecondNumber(threeDigitNum));
Console.WriteLine("----------------------");



//- Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine($"Дано число из отрезка [10, 99] {twoDigitNum}. Показать наибольшую цифру числа");
int getMaxFromNaumber(int num)
{
    int first = System.Math.Abs(num / 10);
    int second = num % 10;
    int max = first > second ? first : second;
    return max;
}
Console.WriteLine(getMaxFromNaumber(twoDigitNum));
Console.WriteLine("----------------------");



//- Удалить вторую цифру трёхзначного числа
Console.WriteLine($"Удалить вторую цифру трёхзначного числа {threeDigitNum}");
int removeSecondNum(int num)
{
    int number;
    int fnum = System.Math.Abs(num / 100) * 10;
    int lnum = num % 10;
    number = fnum + lnum;

    return number;
}
Console.WriteLine(removeSecondNum(threeDigitNum));
Console.WriteLine("----------------------");




//- Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine($"Выяснить, кратно ли число {num} заданному {twoDigitNum}, если нет, вывести остаток.");
void isMultipleToNum(int a, int b)
{
    int remainder = a % b;

    if (remainder == 0)
        Console.WriteLine($"число {a} кратно {b}!!!");
    else
        Console.WriteLine($"число {a} делится на {b} с остатком {remainder}");
}
isMultipleToNum(num, twoDigitNum);
// для проверки
isMultipleToNum(594, 27);
Console.WriteLine("----------------------");




//- Найти третью цифру числа или сообщить, что её нет
Console.WriteLine($"Найти третью цифру {twoDigitNum} и {num * threeDigitNum} или сообщить, что её нет.");
void getThirdNumber(int num)
{
    int number = num % 10;
    int tmp = num; // только для красивого вывода

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
getThirdNumber(twoDigitNum);
getThirdNumber(num * threeDigitNum);
// для проверки
getThirdNumber(999);
getThirdNumber(100);
Console.WriteLine("\n----------------------");



// Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
void getMinMaximum(int a, int b)
{
    int max = a > b ? a : b;
    Console.WriteLine($"a={a}, b={b}, max -> {max}");
}
getMinMaximum(5, 7);
getMinMaximum(2, 10);
getMinMaximum(-9, -3);
Console.WriteLine("\n----------------------");



//-Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел");
getMaximum(2, 3, 7);
getMaximum(44, 5, 78);
getMaximum(22, 3, 9);
Console.WriteLine("\n----------------------");


// - Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4->да
//- 3->нет
//7->нет
Console.WriteLine("четное ли число {0}? - {1}", 4, isEvenNumber(4));
Console.WriteLine("четное ли число {0}? - {1}", 3, isEvenNumber(3));
Console.WriteLine("четное ли число {0}? - {1}", 7, isEvenNumber(7));
Console.WriteLine("\n----------------------");



//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine($"Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
void printEvenNumbers(int num)
{
    Console.WriteLine($"N = {num}");
    // фактически, i должно быть равно 0, ведь 0 - тоже четное число.
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
    }
}
printEvenNumbers(5);
Console.WriteLine("\n----------------------");
printEvenNumbers(8);
