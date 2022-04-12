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
Console.WriteLine(sum);
sum = GetSumNumbers(4, 8);
Console.WriteLine(sum);


// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
