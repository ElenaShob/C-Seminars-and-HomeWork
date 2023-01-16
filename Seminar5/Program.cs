//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}


/*int[] CreateArray(int size)
{
int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input an {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
   
    return array;

}
*/

void ShowArray(int[] array)

{
    for( int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

int GetSumOfNegative(int[] array)
{
    int sum = 0;

    for(int i=0; i < array.Length; i++)
        if(array[i] < 0) 
            sum += array[i];
    return sum;
}

/*
Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int [] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);

int result = GetSumOfNegative(newArray);
Console.WriteLine("Sum of negative elements is " + result);
*/

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int Replace (int[] array)
{

for (int i =0; i<array.Length; i++)
    array[i] = array[i]*-1;
return array;
}


Console.Write("Input a number of elememts: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(m, min, max);
int
*/
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
bool GetSearch(int[]array, int x)
{
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]==x) 
            return true;
        
    }
    return false;
}

Console.Write("Input a number of elememts: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(m, min, max);
ShowArray (array);
Console.WriteLine(GetSearch(array, x));
*/

//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [a,b] включительно.


/*
int GetCountFinf(int[]array, int min, int max)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
        if (array[i]>=min && array[i]<=max)
        count++;
    
    return count;
}

Console.Write("Input a number of elememts: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(m, min, max);
ShowArray (array);
int result = GetCountFinf(array, a, b);
Console.WriteLine("Количество чисел: " + result);
*/
