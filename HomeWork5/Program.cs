//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)

{
    for( int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

int CountEvenNumber(int[] array)
{
int count = 0;
for(int i = 0; i < array.Length; i++)
    if(array[i] % 2 == 0) 
        count++;
return count;
}

Console.Write("Введите длинну массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное трехзначное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное трехзначное число: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newarray = CreateRandomArray(lenght, min, max);
ShowArray(newarray);
int num = CountEvenNumber(newarray);
Console.WriteLine("Количество четных чисел в массиве: " + num);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)

{
    for( int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumUnEven(int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
        sum += array[i];
    return sum;
}

Console.Write("Введите длинну массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newarray = CreateRandomArray(lenght, min, max);
ShowArray(newarray);
int summ = SumUnEven(newarray);
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях в массиве: " + summ);
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

/*
double [] CreateRandomRealArray(int size, int minValue, int maxValue) //ограничила двумя знаками после запятой
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    array[i] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
    return array;
}

void ShowReal2Array(double[] array) 

{
    for( int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

double FindMinNum(double[] array)
{
    
    double min_num = array[0];
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] < min_num) min_num = array[i];
    }
    return min_num;
}

double FindMaxNum(double[] array)
{
    double max_num = array[0];
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] > max_num) max_num = array[i];
    }
    return max_num;
}

Console.Write("Введите длинну массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] newarray = CreateRandomRealArray(lenght, min, max);
ShowReal2Array(newarray);
double minimum = FindMinNum(newarray);
double maximum = FindMaxNum(newarray);
double result = Math.Round(maximum - minimum, 2);
Console.WriteLine($"Разница между максимальным {maximum} и минимальным {minimum} элементами массива равна: {result}");
*/