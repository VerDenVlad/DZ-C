﻿/*Задача 2: 

Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Решение:

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " > " + secondNumber);
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine(secondNumber + " > " + firstNumber);
}
else
{
    Console.WriteLine(secondNumber + " = " + firstNumber);
}
*/

/*Задача 4: 

Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Решение:

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}
*/

/*Задача 6: 

Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Решение:

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 2 == 0)
    {
        Console.WriteLine(number + " - Четное число: ");
    }
    else
    {
        Console.WriteLine(number + " - Нечетное число");
    }
*/

/*Задача 8: 
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

Решение:

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;


while(startNumber <= number)
    {
        if(startNumber % 2 ==0)
        Console.Write(startNumber + ", ");
        startNumber ++;
    }
 */