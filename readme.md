## Greek Brain group 2121 Home work CSharp
**Урок 1. Знакомство с языком программирования С#**
 - Вывести квадрат числа
 - Найти максимальное из трех чисел
 - Выяснить является ли число чётным
 - Показать последнюю цифру трёхзначного числа
 - Показать вторую цифру трёхзначного числа
 - Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
 - Удалить вторую цифру трёхзначного числа
 - Выяснить, кратно ли число заданному, если нет, вывести остаток.
 - Найти третью цифру числа или сообщить, что её нет

**Урок 2. Массивы и функции в программировании**
 - Показать числа от -N до N
 - Показать четные числа от 1 до N
 - Дано число обозначающее день недели. Выяснить является номер дня недели выходным
 - По двум заданным числам проверять является ли одно квадратом другого
 - Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
 - Найти расстояние между точками в пространстве 2D/3D

 ## ДЗ для группы 2164

 - Задача 2
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
```
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
```
 - Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
```
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
```
 - Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
```
4 -> да
-3 -> нет
7 -> нет
```
- Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
```
5 -> 2, 4
8 -> 2, 4, 6, 8
```

# Урок 3. Массивы и функции в программировании
 - Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
```
14212 -> нет
23432 -> да
12821 -> да
```
 - Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
```
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
```
 - Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
```
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
```
# Урок 4. Функции продолжение
 - Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
```
3, 5 -> 243 (3⁵)
2, 4 -> 16
```
 - Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
```
452 -> 11
82 -> 10
9012 -> 12
```
 - Задача 29: Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
```
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
```
# Урок 5. Функции продолжение
- Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
```
[345, 897, 568, 234] -> 2
```
- Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
```
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
```
- Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
```
[3 7 22 2 78] -> 76
```
# Урок 6. Двумерные массивы и рекурсия
 - Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
```
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
```
- Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
```
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
```

# Урок 7. Как не нужно писать код. Часть 1

- Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
```
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
```
- Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
```
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
```
- Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
```
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
```