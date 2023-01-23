﻿// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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

void Show2Array(int[,] array)
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

int[,] myArray = CreateRandom2dArray();
Show2Array(myArray);
*/

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aij = i+j. Выведите полученный массив на экран.
// сумма индексов
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



void Show2Array(int[,] array)
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

int[,] myArray = CreateRandom2dArray();
Show2Array(myArray);
*/
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
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
            array[i,j] = new Random().Next(minValue, maxValue+1);;
            
        
    return array;
}

int FindEvent (int[,]array)
[
   for (int i = 0; i < array.GetLength(0); i=+2)
   {
        for (int j = 0; j < array.GetLength(1); j=+2)
        {
           array[i,j] *= array[i,j];
        }
   }
   return array; 
]

void Show2Array(int[,] array)
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

int[,] myArray = CreateRandom2dArray();
Show2Array(myArray);
*/

// Найдите сумму элементов, нах. на гл. диагонали
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

int GetSum(int[,] array)
{
    int sum = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   // for (int j = i; j < array.GetLength(1); j++)
    
            sum += array[i,i];
   
   return sum;
}

void Show2Array(int[,] array)
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

int[,] myArray = CreateRandom2dArray();
Show2Array(myArray);
Console.WriteLine(GetSum(myArray));
*/