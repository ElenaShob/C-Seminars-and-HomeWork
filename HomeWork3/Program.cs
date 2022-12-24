// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool NumberPaly(int number)
{
int d = 9;
int n = 0;
int x = 1;
int FirstDig = 1;
int LastDig = 1;
while (n == 0 && d >= 0)
    {
    n = number / Convert.ToInt32(Math.Pow(10,d));
    d = d-1;
    }
d = d+1;
FirstDig = number / Convert.ToInt32(Math.Pow(10,d));
LastDig = number % Convert.ToInt32(Math.Pow(10,x));

if (FirstDig == LastDig)
    {
    while (x <= d) 
        {  
            FirstDig = number / Convert.ToInt32(Math.Pow(10,d)) % 10;
            LastDig = number % Convert.ToInt32(Math.Pow(10,x)) / Convert.ToInt32(Math.Pow(10,(x-1)));
            d = d - 1;
            x = x + 1;
            if (FirstDig != LastDig)
            return false;
        } 
    return true;    
    }
else return false;
}

Console.WriteLine("Введите число типа integer (до 2147483647): ");
int num = Convert.ToInt32(Console.ReadLine());

if (NumberPaly(num))
    Console.WriteLine("Число " + num + " является палиндромом");
else
    Console.WriteLine("Число " + num + " не является палиндромом");
*/

// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

