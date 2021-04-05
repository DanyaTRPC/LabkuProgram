using System;

namespace lab8_5_t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть n більше або рівне 2:");
            int n = Convert.ToInt32(Console.ReadLine());
            double f = 1;
            double ff = 1;
            double fff = 0;
            for (int i = 1; i<n; i++)
            {
                fff = ff + (2*f);
                f = ff;
                ff = fff;
            }
            Console.WriteLine($"Результат = {fff}");
        }
    }
}
