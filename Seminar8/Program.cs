//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами строки массива, заданные пользователелм.
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

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >=0 && row1 < array.GetLength(0) &&
       row2 >=0 && row2 < array.GetLength(0) &&
       row1 != row2)
       {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
       }
}

int[,] newArray = CreateRandom2dArray();
Show2Array(newArray);

Console.WriteLine("Input a number or first row:");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number or second row:");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, r1, r2);
Show2Array(newArray);
*/

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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

void ChangeArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;

        }
        
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2Array(newArray);
ChangeArray(newArray);
Show2Array(newArray);
*/

//Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

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

int [] FindMin(int[,] array)
{
    int minrow = 0;
    int mincol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if(array[i,j]<array[minrow, mincol])
            {
                minrow = i;
                mincol= j;
            }
        }
    }
    int[] indexes = {minrow, mincol};
    return indexes;
}



int[,] NewArray(int[,] array, int[]indexes)
{
    int[,]massiv = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    for (int i = 0, x = 0; i < array.GetLength(0); i++, x++)
    {
        if(indexes[0] == i) 
        {
            x--;
            continue;
        }
        else
        for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)
        {
            if(indexes[1] == j)
            {
                y--;
                continue;
            }
            else
            massiv[x,y] = array[i,j];

        }
    }
   
    return massiv;
}

int[,] newArray = CreateRandom2dArray();
Show2Array(newArray);
Show2Array(NewArray(newArray, FindMin(newArray)));

