using System;

namespace lab6t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a1= ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("a2= ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("a3= ");
            double a3 = double.Parse(Console.ReadLine());
            Console.Write("b1= ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("b2= ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("b3= ");
            double b3 = double.Parse(Console.ReadLine());
            double A = a2 * b3 - a3 * b2;
            double B = a3 * b1 - a1 * b3;
            double C = a1 * b2 - a2 * b1;
            Console.WriteLine("{0};{1},{2}", A, B, C);

        }
    }
}
