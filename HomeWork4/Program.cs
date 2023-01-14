// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*

int CustomPow(int num, int pow)
{
    int product = 1;
    for(int i = 1; i <= pow; i++)
    product *= num;

    return product;
}

Console.Write("Input a number А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = CustomPow(a,b);
Console.WriteLine($"{a} to the power of {b} equals {result}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*

int SumDigit(int num)
{
    int count = 0;
    int result = 0;
    while(num !=0)
    {
        result += num%10;
        num = num/10;
        count++;
    }
    return result;

}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = SumDigit(a);
Console.WriteLine($"Sum of digit: {result}");
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//Массив задается пользователем
/*
int [] CreateUserArray ()
{
    Console.Write("Из скольки чисел будет состоять массив: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i<array.Length-1)
        Console.Write(", ");
    }
    Console.WriteLine();
}

int [] newArray = CreateUserArray();
ShowArray(newArray);
*/