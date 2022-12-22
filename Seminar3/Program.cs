//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат 
//точек в этой четверти (x и y).
/*
void GetDiapazone(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");    
}

Console.Write("Input number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);
*/

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
//четверти плоскости, в которой находится эта точка.
/*
int Quadr(int x, int y)

{
    int quad = 0;
    if (x>0 && y>0)  quad = 1;
    else if (x<0 && y>0) quad = 2;
    else if (x<0 && y<0) quad = 3;
    else if (x>0 && y<0) quad = 4;
    return quad;
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четверть плоскости: " + Quadr(x, y));
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.

/*
void Quad(int n)
{
	int result = 0;
	for (int i = 1; i <= n; i++)
	{
		result = i * i;
		Console.WriteLine($"{result} ");
	}
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Quad(n);
*/
//или
/*
void QuadrNumbers(int n)
{
    int index = 1;
    while (index<=n)
    {
       int result = index * index;
       index ++;
       Console.WriteLine(result);
    }
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
QuadrNumbers(number);
*/

//Напишите программу, которая принимает на вход координаты двух точек 2Д и находит расстояние между ними

/*
double Method(double x1, double y1, double x2, double y2)
{
    double result = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return result;
}
Console.WriteLine("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние: " + Method(x1, y1, x2, y2));
*/

