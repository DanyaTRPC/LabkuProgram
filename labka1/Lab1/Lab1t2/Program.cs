using System;

namespace Lab4t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            int c = int.Parse(Console.ReadLine());
            if (3 <= a && a <= 9 || b <= a && b <= c)
            {
                Console.WriteLine("a належить цілим числам");
            }
            else
            {
                Console.WriteLine("a не належить цілим числам");
            }

        }
    }
}
