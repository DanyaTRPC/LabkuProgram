using System;

namespace lab5t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення x=");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення n=");
            int n = int.Parse(Console.ReadLine());

            
            if (n > 0)
            {
                double k = Math.Pow(x + a, 2);
                n -= 1;
                while (n > 0)
                {
                    k = Math.Pow(k + a, 2);
                    n -= 1;
                }
                k += a;
                Console.WriteLine("k={0}",k);

            }
            else
            {
                Console.WriteLine("Рівняння не виконується");
            }
        }
    }
}
