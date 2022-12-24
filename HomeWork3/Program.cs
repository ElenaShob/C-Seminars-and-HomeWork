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

/*
double Distance3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Round(Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1)), 2);
    return dist;
}

Console.Write("Введите координаты первой точки А. x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки В. x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние между точками А и В с координатами {x1}, {y1}, {z1} и {x2}, {y2}, {z2} равно {Distance3D(x1, y1, z1, x2, y2, z2)}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube1ToN (int number)
{
    int min = 1;
    int max = 1;
    if (number < 0) min = number;
    else max = number;
    while (min < max)
    {
        int cube = min*min*min;
        min ++;
        Console.Write(cube +" ");
    }
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Cube1ToN(a);
*/