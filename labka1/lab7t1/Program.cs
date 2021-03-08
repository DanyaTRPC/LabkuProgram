using System;

namespace lab7t1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double s = 1;
            double[,] arr = new double[n,n];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[i,j]= rand.Next(-10,10));
                }
                Console.WriteLine();
            }
            for(int t = 0; t >= 0 && t <= n - 1; t++)
            {
                for(int h = 0; h < n; h++)
                {
                    if (arr[t,h]>0)
                    {
                        s *= arr[t,h];
                        
                    }
                }
            }

            Console.WriteLine("s= {0}",s);



        }
    }
}
