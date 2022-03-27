//# Урок 4. Функции продолжение
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16
int exponentiation(int number, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}
int num = exponentiation(3, 5);
Console.WriteLine("3^5={0}", num);
num = exponentiation(2, 4);
Console.WriteLine("2^4={0}", num);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int getSumOfNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
int sum = getSumOfNumbers(452);
Console.WriteLine("Сумма чисел в числе 452={0}", sum);

sum = getSumOfNumbers(82);
Console.WriteLine("Сумма чисел в числе 82={0}", sum);

sum = getSumOfNumbers(9012);
Console.WriteLine("Сумма чисел в числе 9012={0}", sum);



//Задача 29: Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

