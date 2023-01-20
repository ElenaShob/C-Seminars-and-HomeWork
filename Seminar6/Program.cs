//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

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

void ReversArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int [] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);
ReversArray(newArray);
ShowArray(newArray);
*/

//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

/*
bool CheckTriangle(int num1, int num2, int num3)
{
    if(num1<num2+num3 && num2<num3+num1 && num3<num1+num2) return true;
    else return false;
}

Console.Write("Введите сторону А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону В: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (CheckTriangle(a,b,c))
    Console.WriteLine("Такой треугольник существует.");
else
    Console.WriteLine("Такой треугольник не существует");
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: a и b.
/*
void ShowArray(int[] array)

{
    for( int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] Fibonacci(int size, int first, int second)
{
int[] array = new int[size];
array[0] = first;
array[1] = second;
for(int i = 2; i<size; i++)
    array[i] = array[i-1]  + array[i-2];
 return array;   
}
Console.Write("Введите первый элемент: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй элемент: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] newarray = Fibonacci(n, a, b);
ShowArray(newarray);
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/
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

int[] CopyArray(int[] array)
{
    int[] copyArray = new int [array.Length];
    for(int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    return copyArray;
}

Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);
int[] copyArray = CopyArray(newArray);
ShowArray(copyArray);
newArray[2] = 5;
ShowArray(newArray);
ShowArray(copyArray);
*/
