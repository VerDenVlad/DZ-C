/* Задача 19 - Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

Решение:


Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int num = number.Length;

if (num == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Да, это палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - Нет, это не палиндром");
    }
}    
else Console.WriteLine($"{number} - Вы ввели некорректное число"); //закомментировать

//if (num < 5) Console.WriteLine($"{number} - Вы ввели меньше 5 знаков"); //раскомментировать
//if (num > 5) Console.WriteLine($"{number} - Вы ввели больше 5 знаков"); //раскомментировать
*/

/* Задача 21 - Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Решение:


double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    double deltaZ = z1 - z2;
    return Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ), 2);
}
Console.Write("Введите координаты x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние составляет {0:f2}", Distance (x1, y1, z1, x2, y2, z2));

*/

/* Задача 23 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Решение:


void WriteCube(int number)
{
    int current = 1;
    while (current <= number)
    {
        Console.WriteLine($"{current} - {current * current * current}");
        current++;
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
WriteCube (number);

*/