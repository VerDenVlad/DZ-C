/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Решение


int numA = InputNum("Введите число A: ");
int numB = InputNum("Введите число B: ");

Step(numA, numB);

void Step(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Число {numA} в степени {numB} равно {result}");
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Решение:


int number = InputNum("Введите число: ");
int len = Numbers(number);
SumNumbers(number, len);

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Numbers(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Общая сумма цифр в числе {number} = {sum}");
}
*/

/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Решение:


Console.Write("\n Сколько будет элементов в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a];

for(int i = 0; i < array.Length; i++)
{
    //Console.Write($"\n Введите {i+1} элемент массива под индексом {i}: ");
    //Console.Write($"\n Введите элемент массива под индексом {i}: ");  
    Console.Write($"\n Введите {i+1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}


Console.Write("\n Результат массива: ");
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}


Console.WriteLine();

*/