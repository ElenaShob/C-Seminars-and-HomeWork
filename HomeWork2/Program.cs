// Задача 10.
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNumber(int number)
{
    int second = number / 10 % 10;
    return second;
}

Console.WriteLine("Input three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 100 || a >= 1000)
{
    Console.WriteLine("You input not three-digit number! ");
}
else
{
Console.WriteLine("Second number is: " + SecondNumber(a));
}
*/

// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int ShowThirdDigit(int number)
{
   int third = number % 10;
   return third; 
}

int CutToThree(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
    Console.WriteLine("There is no third digit here!");
if (a >= 1000)
    a = CutToThree(a);
if (a >= 100 && a < 1000)
    Console.WriteLine("The third digit is: " + ShowThirdDigit(a));    
*/

// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool WeekEnd(int number)
{
    if (number == 6 || number == 7)
    return true;
    else
    return false;
}

Console.Write("Input a number of the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >=1 && day <=7)
{
    if (WeekEnd(day))
    {   
        Console.WriteLine("Wow! Today is the weekend!");
    }
    else
    {
        Console.WriteLine("Ups! It's not a weekend today!");
    }
}
else
Console.WriteLine("Error. It's not a day of the week! Try again!");
*/