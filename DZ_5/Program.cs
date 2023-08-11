/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Решение

int size = 5;
int[] numbers = new int[size];
RandNumb(numbers);
NumbArray(numbers);

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) count ++;
}
Console.Write("Четных чисел в массиве: " +count);

void RandNumb(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void NumbArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


Решение


int size = 5;
int[] numbers = new int[size];
RandNumb(numbers);
NumbArray(numbers);

int sumNumb = 0;

for (int i = 1; i < numbers.Length; i += 2)
{
    sumNumb+= numbers[i];
}
Console.Write("Сумма элементов = " +sumNumb);

void RandNumb(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void NumbArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//*/

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


Решение


Console.Write ("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
double [] RandMas (int size, double min, double max)
{
        double [] array = new double [size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round((new Random().NextDouble()*(max -  min)+min), 2);
      
    return array;
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double MinMax(double[] array)
{
    double min = array[0];
    double max = array[0];

    double dif = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
        else if (max < array[i])
            max = array[i];
    }

    dif = max - min;
    Console.WriteLine("min значение массива :" +min);
    Console.WriteLine("max значение массива :" +max);
    return dif;
}

Console.Write ("Введите минимальное число массива: ");
double min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
double max = Convert.ToInt32(Console.ReadLine());
double[] myArray = RandMas (size, min, max); 
WriteArray(myArray);
Console.WriteLine("Разница между min и max: " + (Math.Round(MinMax(myArray), 2)));
*/