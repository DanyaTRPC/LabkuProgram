using System;

namespace lab6t1
{
    class Program
    {
        public class Example 
        { 
        
        public static void Main()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

                double min = 1000;
                double[] list = new double[n];
                for(int i = 0; i<n; i++)
                {
                    list[i] = double.Parse(Console.ReadLine());
                    
                }
            
                for (int i = 0; i < n; i += 1)
                {
                    if (min > list[i])
                    {
                        min = list[i];
                    }
                }
                for(int i = 0; i < n; i++)
                {
                    Console.Write("{0}", list[i]);
                }
                Console.WriteLine("Найменше значення в списку: {0}", min);


        } 
        }
    }
}

