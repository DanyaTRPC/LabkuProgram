using System;

namespace lab7_4_t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть рядкiв та стовпцiв = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int maxValue = 100;
            int minValue = -100;

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

            for (int k = 0; k < n; k += 2)
            {
                for (int i = 0; i < n - 1; i++)
                {

                    int indexMin = i;
                    for (int j = i + 1; j < matrix.Length; j++)
                    {
                        if (matrix[j][k] < matrix[indexMin][k])
                            indexMin = j;
                    }
                    if (i != indexMin)
                    {
                        double z = matrix[i][k];
                        matrix[i][k] = matrix[indexMin][k];
                        matrix[indexMin][k] = z;
                    }
                }
            }

            // Виведення матриці.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
        }
    }
}
