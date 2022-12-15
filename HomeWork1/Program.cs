//Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input First numer: ");
double a = Convert.ToDouble(Console.ReadLine()); //использую double так как не сказано целые ли числа
Console.Write("Input Second number: ");
double b = Convert.ToDouble(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}
else
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);  
}
*/

//Задача 4.
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input first number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second number: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Input third number: ");
double c = Convert.ToDouble(Console.ReadLine());

double max = a;

if (b > max)    max = b;
if (c > max)    max = c;

Console.WriteLine("Maximum is " + max);
*/

//Задача 6. 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) 
{
    Console.WriteLine($"Число {a} четное");
}
else
{
    Console.WriteLine($"Число {a} нечетное");
}
*/

//Задача 8.
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int current = 1;
int count = 1;
    if(a < 0) count = -1;
    if(a == 0) current = 0;
while(current <= a * count)
{
        if(current % 2 == 0)  Console.Write(current * count + " ");
    current = current + 1;
}
*/


