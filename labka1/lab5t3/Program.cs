using System;

namespace lab5t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x=");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            double s = 1;
            if (n > 0 && a > 0)
            {



                for (int j = 0; 1 < j && j < n + 1; j++)
                {
                    double factorial = 1;
                    double factorial1 = factorial * j;
                    double f = Math.Pow(x * Math.ILogB(a - 1), j) /factorial * j;
                   s += f;

                }
                double e = Math.Pow(x, a) - s;
                Console.WriteLine(e);
                }


            else
            {
                Console.WriteLine("Рівняння не виконується");
            }
            }
                
            
        }
    }

