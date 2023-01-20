// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int CountNumbers(int size) 
{
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) // не считаю 0 положительным.
            count +=1;
    }
    return count;
}

Console.Write("Введите количество чисел для проверки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество положительных чисел: " + CountNumbers(m));
*/

//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

/*
void SearchPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x + b1;
    Console.WriteLine($"Координаты точки пересечения прямых: x = {x}, y = {y}");
}

Console.Write("В уравнении y = k1 * x + b1 задайте k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("В уравнении y = k1 * x + b1 задайте b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("В уравнении y = k2 * x + b2 задайте k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("В уравнении y = k2 * x + b2 задайте b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

SearchPoint(k1, b1, k2, b2);
*/