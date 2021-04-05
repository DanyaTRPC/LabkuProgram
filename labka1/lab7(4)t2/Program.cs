using System;

namespace lab7_4_t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть рядкiв та стовпців = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int maxValue = 10;
            int minValue = -10;
            double sum = 0;

            // Генерування рандомної матриці n x n.
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

            // Виведення матриці.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
            Console.Write($"Виберіть номер рядка який менший за {n} = ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Виберіть номер стовпця який менший за {n} = ");
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<n; i++)
            {
                sum += matrix[k-1][i]*matrix[i][p-1];

            }
            Console.WriteLine($"Скалярний добуток обраного рядка та стовпця = {sum}");

        }
    }
}
