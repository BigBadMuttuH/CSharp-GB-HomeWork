// Задача 64:
// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до M.
// M = 1; N = 5. -> "5, 4, 3, 2, 1"
// M = 4; N = 8. -> "8, 7, 6, 7"
void GetNumbers(int num1, int num2)
{
    Console.Write($"{num2} ");
    if (num1 < num2)
    {
        GetNumbers(num1, --num2); 
    }
}

GetNumbers(1, 5);
Console.WriteLine();
GetNumbers(4, 8);
Console.WriteLine("\n");

// Задача 66:
// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30
int GetSumNumbers(int num1, int num2, int sum = 0)
{
    if (num1 == num2)
    {
        return sum += num1;
    }
    else
    {
        sum += num1;
        return GetSumNumbers(++num1, num2, sum);
    }
}
int sum = GetSumNumbers(1, 15);
Console.WriteLine("Сумма числе между 1 и 15 =" + sum);
sum = GetSumNumbers(4, 8);
Console.WriteLine("Сумма числе между 4 и 8 =" + sum);

Console.WriteLine();
// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// A(m,n) m==0, n+1
// A(m,n) n==0 A(m - 1, n)
// A(m,n) m > 0 && n > 0 A(m - 1, A(m, n-1))
double Akkerman(double m, double n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    else
        return -1;
}

//m = 0, n = 0 A = 1    m = 1, n = 0 A = 2    m = 2, n = 0 A = 3    m = 3, n = 0 A = 5    m = 4, n = 0 A = 13
//m = 0, n = 1 A = 2    m = 1, n = 1 A = 3    m = 2, n = 1 A = 5    m = 3, n = 1 A = 13   Stack overflow.
// Repeat 13771 times:

//m = 0, n = 10 A = 11  m = 1, n = 10 A = 12  m = 2, n = 10 A = 23  m = 3, n = 10 A = 8189
//m = 0, n = 11 A = 12  m = 1, n = 11 A = 13  m = 2, n = 11 A = 25  Stack overflow.
//                  Repeat 12051 times:
double a = 0;
for (int n = 0; n < 10; n++)
{
    for (int m = 0; m < 4; m++)
    {
        a = Akkerman(m, n);
        Console.Write($"m={m}, n={n} A={a}\t");
    }
    Console.WriteLine();
}