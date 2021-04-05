using System;

namespace lab8_5_t2
{
    class Program
    {
        static double[] dobNum(double[] x, double y, int n)
        {
            double[] d = new double[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = x[i] * y;
            }
            return d;
        }
        static double[] dodVect(double[] x, double[] y, int n)
        {
            double[] d = new double[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = x[i] + y[i];
            }
            return d;
        }
        static double[] vidnVect(double[] x, double[] y, int n)
        {
            double[] d = new double[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = x[i] - y[i];
            }
            return d;
        }
        static void Main(string[] args)
        {

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("b[{0}] = ", i + 1);
                b[i] = int.Parse(Console.ReadLine());
            }
            double[] c = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("c[{0}] = ", i + 1);
                c[i] = int.Parse(Console.ReadLine());
            }
            double[] z1 = dobNum(b, 3, n);
            double[] z2 = dobNum(c, 2, n);
            double[] z3 = vidnVect(a, z1, n);
            double[] z4 = dodVect(z3, z2, n);

            for (int i = 0; i < n; i++)
            {

                Console.Write("s[{0}] = {1}; ", i + 1, z4[i]);
            }
        }
    }
}
