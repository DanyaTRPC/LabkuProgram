using System;

namespace lab1t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення: a= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення: b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення: x= ");
            double x = double.Parse(Console.ReadLine());
            double radX = x / 180 * Math.PI;
            double s = a * b * Math.Sin(radX) / 2;
            Console.WriteLine(s);
                

        }
    }
}
