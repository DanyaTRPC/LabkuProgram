using System;

namespace lab7_4_t5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть рядкiв та стовпцiв = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int maxValue = 10;
            int minValue = -5;
            double d = 1;

            double[][] matrix = new double[n][];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = Convert.ToInt32(rnd.NextDouble() * (maxValue - minValue) + minValue);
                }
            }

            for (int i = 0; i < n; i++)
            {
                int k = 0;
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j]<0) 
                    {
                        k = 1;
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    if (k == 0)
                    {
                        d *= matrix[i][j];
                    }
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------");
            if (d == 1)
            {
                Console.Write("Добуток елементiв в тих рядках, якi не містять вiд’ємних елементiв = 0");
            }
            else
            {
                Console.Write($"Добуток елементiв в тих рядках, якi не мiстять вiд’ємних елементiв = {d}");
            }
            
        }
    }
}
