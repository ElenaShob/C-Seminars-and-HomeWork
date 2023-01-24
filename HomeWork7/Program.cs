// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandomReal2dArray()
{
    Console.Write("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,]array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
             
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] newArray = CreateRandomReal2dArray();
Show2dArray(newArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,]array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
            
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void ReturnElement(int[,] array)
{
    Console.Write("Input index row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input index column: ");
    int column = Convert.ToInt32(Console.ReadLine()); 
    if (row >= array.GetLength(0) || column >= array.GetLength(1))
        Console.WriteLine("Числа с такими индексами в массиве нет");
    else Console.WriteLine("Число с заданными индексами: " + array[row,column]);
    
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ReturnElement(myArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,]array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
            
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

double[] AverageColumns(int[,] array)
{
    int l = array.GetLength(1);
    double[] resultArray = new double[l];
    double result = 0;
   
       for (int j = 0; j < l; j++)
        {   double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                sum += array[i,j];
            
            result = sum / l;
            resultArray[j] = Math.Round(result,2);
        }
        return resultArray;
}
    
void ShowArray(double[] array)

{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
        if (array[i] == array[array.Length-1]) 
            Console.Write(array[i] + ".");
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] newArray = AverageColumns(myArray);
Console.WriteLine($"Среднee арифметическое каждого столбца: ");
ShowArray(newArray);
*/