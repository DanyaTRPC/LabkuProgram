using System;

namespace lab5t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            double[] k = new double[] {0,9} ;
            if (n >= 2)
            {
                for(int i = 0; i>=2 && i<= n+1; i++)
                {
                    double x = 2 * k[i - 1] + 3 * k[i - 2];
                    k. = x;
                }
            }
        }
    }
}
