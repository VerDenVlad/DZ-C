/*Задача 10: 

Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1


Решение:


int TwoNumber(int num)
{    
    int result = ((num / 10) % 10);
    return result;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = number.ToString().Length;

if (sum < 3 || sum > 3) Console.WriteLine("Ошибка! Вы ввели не трехзначное число");

else Console.WriteLine("Вторая цифра " +TwoNumber(number));

*/


/* Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6


Решение:


int MakeArray(int a, int b)
{
int result = -1;
    if (b < 3)
    {
        Console.Write("Ошибка! Число слишком короткое ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}

Console.Write("Input the number ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

*/


/*Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

Решение:

string Workday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6) Console.Write($"Под цифрой {a} - Выходной день");
        else Console.Write($"Под цифрой {a} - Рабочий день");
    }
    else Console.Write("Ошибка! Вы ввели число не в диапозоне от 1 до 7");
    return ".";
}

Console.Write("Введите число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Workday(dayNumber));

*/