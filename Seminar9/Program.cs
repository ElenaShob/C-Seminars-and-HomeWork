//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    Console.Write(num + " "); //будет с 5 до 1
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " "); // будет с 1 до 5
}

ShowNums(5);
*/
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int GetSumOfDigits(int num)
{
    if(num !=0) 
    return GetSumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(GetSumOfDigits(1234));
*/
//f(1234) -> 4 + f(123)
//f(123) -> 3 + f(12)
//f(12) -> 2 + f(1)
//f(1) -> 1 + (0)
//f(0) -> 0 отсюда пошли обратно
//f(1) -> 1 + (0) = 1 + 0 = 1
//f(12) -> 2 + f(1) = 2 + 1 = 3
//f(123) -> 3 + f(12) = 3 + 3 = 6
//f(1234) -> 4 + f(123) = 4 + 6 = 10

//Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N.
/*
void ShowNums(int M, int N)
{
  //  Console.Write(num + " "); будет с 5 до 1
    if(M > N) 
    {
    Console.Write(M + " ");
    ShowNums(M - 1, N);
    }
    else if (M < N)
    {
    ShowNums(M, N-1);
    Console.Write(N + " ");
    }
    else Console.Write(N + " ");
     // будет с 1 до 5
}

ShowNums(5, 5);
*/

// Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B.
/*
double Method(double A, double B)
{
    if(B<0) return Math.Round(1/A*Method(A,B+1),4);
    else if (B!=0) return A*Method(A, B-1);
    else return 1;
}

Console.Write(Method(2,-3));
*/