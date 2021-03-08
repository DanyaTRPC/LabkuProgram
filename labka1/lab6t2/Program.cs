using System;


namespace lab6t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            double[] listA = new double[] { };
            double[] listB = new double[] { };
            double a;
            double s1 = 0;
            double s2 = 0;
            for(int i = 0; i>=1 && i<=n+1; i++)
            {
                double radL = i / 180 * Math.PI;
                a = ((2 * i - 1) * Math.Cos(i)) / Math.Pow(i, 2);
                if (a > 0)
                {
                    listA[i] = a;
                    for (int j = 0; j < n; j++)
                    {
                        s1 += Math.Pow(j, 2);
                    }
                }
                else
                {
                    listB[i] = a;
                    for (int t = 0; t < n; t++)
                    {
                        s2 += Math.Pow(t, 2);
                    }
                }
                if (s2 < s1)
                {
                    int z = -1;
                    Console.WriteLine("z= {0}", z);
                }
                else
                {
                    int z = 1;
                    Console.WriteLine("z= {0}", z);
                }
                

            }
            
            




        }
    }
}
