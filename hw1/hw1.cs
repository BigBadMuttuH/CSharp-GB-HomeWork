int twoDigitNum = new Random().Next(10,99);
int threeDigitNum = new Random().Next(100,999);
int num = new Random().Next(1,999);


Console.WriteLine($"Вывести квадрат числа {num}");
int getSquare(int num)
{
    num = num * num;
    return num;
}
Console.WriteLine(getSquare(num));
Console.WriteLine("----------------------");


Console.WriteLine($"Найти максимальное из трех чисел {num},{twoDigitNum},{threeDigitNum}");
int getMaximum(int a, int b, int c)
{
    int max = a;
    if (b > c && max < b) max = b;
    else if (c > b && max < c) max = c;
    return max;
}
Console.WriteLine(getMaximum(num, threeDigitNum, twoDigitNum));
Console.WriteLine("----------------------");


Console.WriteLine($"Выяснить является ли число {threeDigitNum} чётным");
bool isEvenNumber(int number)
{
    bool isEvenNumber = number % 2 == 0;
    return isEvenNumber;
}
Console.WriteLine(isEvenNumber(threeDigitNum));
Console.WriteLine("----------------------");



Console.WriteLine($"Показать последнюю цифру трёхзначного числа {threeDigitNum}");
int getLastNumber(int num)
{
    int number = num % 10;
    return number;
}
Console.WriteLine(getLastNumber(threeDigitNum));
Console.WriteLine("----------------------");


Console.WriteLine($"Показать вторую цифру трёхзначного числа {threeDigitNum}");
int getSecondNumber(int num)
{
    int number = System.Math.Abs(num / 10 % 10);
    return number;
}
Console.WriteLine(getSecondNumber(threeDigitNum));
Console.WriteLine("----------------------");


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
Console.WriteLine("----------------------");


Console.WriteLine($"Найти третью цифру {twoDigitNum} и {num * threeDigitNum} или сообщить, что её нет.");
void getThirdNumber(int num)
{
    int number = num % 10;
    int tmp = num; // только для кравивого вывода

    if (num < 100)
        Console.WriteLine($"{num} двухзначное число");
    else
    {
        while(num > 100)
        {
            number = num % 10;
            num = System.Math.Abs(num / 10);
        }   
        Console.WriteLine($"Третья цифра числа {tmp} = {number}");
    }
}
getThirdNumber(twoDigitNum);
getThirdNumber(num * threeDigitNum);