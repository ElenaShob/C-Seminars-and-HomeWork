﻿//Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
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

int[,] SortToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1)-1; k++) 
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if(array[i,j] < array[i,j+1])
                    {
                    int temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                    } 
            }
            
        }
            
    }
    return array;
}
    


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
SortToMin(myArray);
Show2dArray(myArray);
*/

