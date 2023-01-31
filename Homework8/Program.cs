//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
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

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
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

int FindMinSumRow(int[,] array)
{
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        int minSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i,j];
        if (i == 0) 
        {
            minRow = i;
            minSum = sum;
        }
        if(sum < minSum)
        {
            minSum = sum;
            minRow = i; 
        } 
           
    }
    return minRow + 1; //номер строки, а не индекс
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int minRow = FindMinSumRow(myArray);
Console.WriteLine("Cтрока с наименьшей суммой: " + minRow);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    
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

int[,] MultipliedMatrix(int[,] arrayA, int[,] arrayB)
{   
    int[,] resultMatrix = new int [arrayB.GetLength(0), arrayB.GetLength(1)];
    
    for (int l = 0; l < arrayB.GetLength(1); l++)
    {
        for (int i = 0; i < arrayB.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < arrayB.GetLength(0); j++)
                sum += arrayA[i,j] * arrayB[j,l];
            resultMatrix[i,l] = sum;
        }
    }
    return resultMatrix;
}

Console.Write("Input a numbers of rows first matrix: ");
int rowA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns first matrix: ");
int colA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns second matrix: ");
int colB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = CreateRandom2dArray(rowA, colA,minVal, maxVal);
Console.WriteLine("The first matrix: ");
Show2dArray(matrixA);
int[,] matrixB = CreateRandom2dArray(colA,colB, minVal, maxVal);
Console.WriteLine("The second matrix: ");
Show2dArray(matrixB);
int[,] myMatrix = MultipliedMatrix(matrixA, matrixB);
Console.WriteLine("The multiplied of matrix: ");
Show2dArray(myMatrix);
*/
 
//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] CreateRandom3dNotSameArray()
{
    Console.Write("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of axis z: ");
    int zetCoord = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    int massivLength = rows*columns*zetCoord + minValue-1;
    Console.Write("Input a max possible value (at least: " + massivLength + "): ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,]array = new int[rows, columns, zetCoord];
    int[]numbers = new int [maxValue+1];
    int x = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < zetCoord; k++)
            {
                while(numbers[x] == x)
                    x = new Random().Next(minValue, maxValue+1);
               
                numbers[x] = x;
                array[i,j,k] = x;
                
            }
        
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j,k] + "(" + i + "," + j + "," + k + ")");
            }
            Console.WriteLine();  
        }
        
    }
}

int[,,] my3dArray = CreateRandom3dNotSameArray();
Show3dArray(my3dArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] SpiralSquareArray()
{
    int row = 6;
    int column = 6;
    int startNum = 1;
    int k = 0;
    int[,] array = new int[row, column];
    while(startNum<=row*column)
    {
        for(int j = 0+k; j < column-k; j++)
        {
        array[0+k,j] = startNum;
        startNum++;
        }
        startNum--;
        for(int i = 0+k; i < row-k; i++)
        {
        array[i,column-1-k] = startNum;
        startNum++;
        }
        startNum--;
        for(int j = column-1-k; j >=0+k; j--)
        {
        array[row-1-k,j] = startNum;
        startNum++;
        }
        startNum--;
        for(int i = row-1-k; i > 0+k; i--)
        {
        array[i,0+k] = startNum;
        startNum++;
        }
        
        k++;
    }

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

int[,] myArray = SpiralSquareArray();
Show2dArray(myArray);
*/