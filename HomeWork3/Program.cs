int number = 1234321;
int d = 9;
int n = 0;
int x = 1;
int a = 1;
int b = 1;
while (n == 0)
    {
    n = Convert.ToInt32(number / Math.Pow(10,d));
    d = d-1;
    }
a = Convert.ToInt32(number / Math.Pow(10,(d+1)));
b = Convert.ToInt32(number % Math.Pow(10,x));

if (a == b) 
     {
         while (x <= d+1)
          {
                a = Convert.ToInt32(number / Math.Pow(10,d+1)%10);
                b = Convert.ToInt32(number % Math.Pow(10,x)/Math.Pow(10,(x-1)));
                d = d - 1;
                x = x + 1;
                Console.Write("n = " + n + " ");
                Console.Write("d = " + d + " ");
                Console.Write("a = " + a + " ");
                Console.WriteLine("b = " + b + " ");
          } 
     }
     else  
     {
        Console.WriteLine("-1");
     }
       


