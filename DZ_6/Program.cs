/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3


Решение:


Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число {i}: ", i + 1); //Console.Write("Введите число {0}: ", i++);
    int number = Convert.ToInt32(Console.ReadLine()); //int number = int.Parse(Console.ReadLine());
    if (number > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше нуля: {count}");
*/


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Решение:

double x;
double y;

Console.WriteLine("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    x = (double) (b2 - b1) / (k1 - k2);
    y = (double) k1 * x + b1;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {x:0.00}");
    Console.WriteLine($"Y: {y:0.00}");
}
*/