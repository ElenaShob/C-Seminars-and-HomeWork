//Задача. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <=num; current++)
            sum +=current; // sum = sim + current (увеличить переменную sum на переменную current)
    return sum;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine(result);
*/

//Задача. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int GetCount(int num)
{
    int count = 0;
    while(num !=0)
    {
        num = num/10;
        count++;
    }
    return count;
 }

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetCount(a);
Console.WriteLine(result);
*/


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int GetProduct(int num)
{
    int progr = 1;

    for(int current = 1; current <=num; current++)
            progr *=current; // sum = sim + current (увеличить переменную sum на переменную current)
    return progr;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetProduct(a);
Console.WriteLine(result);
*/

//Задача. Массивы.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a number of element: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);