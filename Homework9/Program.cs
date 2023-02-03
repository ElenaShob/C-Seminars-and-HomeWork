// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");; 
    if(num > 1) ShowNums(num - 1);
    else if(num < 1) ShowNums(num + 1);
}
Console.Write("Для вывода всех натуральных чисел в промежутке от N до 1, введите N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Натуральные чиселв в промежутке от N до 1: ");
ShowNums(num);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
/*
int SumOfElements(int M, int N)
{
    if(M==N) return N;
    else if(M>N) 
    return SumOfElements(M, N+1) + N;
    else
    return M + SumOfElements(M+1, N);
        
}

Console.Write("Для сложения элементов в промежутке от М до N введите М: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Для сложения элементов в промежутке от М до N введите N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write(SumOfElements(num1, num2));
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
/*
int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FunctionAkkerman(m-1, 1);
    else return FunctionAkkerman(m-1, FunctionAkkerman(m, n-1));
}

Console.Write("Для вычисления функции Аккермана введите число m: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Для вычисления функции Аккермана введите число n: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write(FunctionAkkerman(num1, num2));
*/