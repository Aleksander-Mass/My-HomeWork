/*
Урок 1. Знакомство с языком программирования С#

Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


//Решение:

Console.Write("Input first integer number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number b: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.Write("max = " + a);
}

else
{
    Console.Write("max = " + b);
}

*/


/*

Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

//Решение:

Console.Write("Input first integer number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) max = a;

if(b > max) max = b;

if(c > max) max = c;

Console.WriteLine(max);

*/


/*
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

//Решение:

Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.Write("Это число является четным : да");
}

else
{
    Console.Write("Это число является нечетным : нет");
}

*/


/*
Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


//Решение:
Console.Write("Input integer positive number N: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < num - 1) Console.Write((i += 2) + ", ");

*/