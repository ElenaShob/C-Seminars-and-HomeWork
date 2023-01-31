// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " "); 
    if(num > 1) ShowNums(num - 1);
    else if(num < 1) ShowNums(num + 1);
}

ShowNums(-5);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

int SumOfElements(int M, int N)
{
    if(M>N) return SumOfElements(M-1, N) + M;
    else if (M<N) return SumOfElements(M+1, N) + N;
    else return 0;
}

Console.Write(SumOfElements(4,8));