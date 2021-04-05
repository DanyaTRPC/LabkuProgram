using System;

namespace lab7_4_t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть рядкiв та стовпцiв = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int maxValue = 10;
            int minValue = -10;

            // Генерування рандомної матриці n x n.
            double[][] A = new double[n][];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = new double[n];
                for (int j = 0; j < n; j++)
                {
                    A[i][j] = Convert.ToInt32(rnd.NextDouble() * (maxValue - minValue) + minValue);
                }
            }

            // Виведення матриці.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", A[i][j]);
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------");

            double[][] B = new double[n][];
            for (int i = 0; i < n; i++)
            {
                B[i] = new double[n];
                for (int j = 0; j < n; j++)
                {
                    B[i][j] = Convert.ToInt32(rnd.NextDouble() * (maxValue - minValue) + minValue);
                }
            }

            // Виведення матриці.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", B[i][j]);
                Console.WriteLine();
            }


            Console.WriteLine("-------------------------");

            double[][] C = new double[n][];
            for (int i = 0; i < n; i++)
            {
                C[i] = new double[n];
                for (int j = 0; j < n; j++)
                {
                    C[i][j] = A[i][j] * B[i][j];

                }
            }

            // Виведення матриці.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", C[i][j]);
                Console.WriteLine();
            }
        }
    }
}
