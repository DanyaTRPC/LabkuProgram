using System;

namespace Lab4t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення a= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення c= ");
            double c = double.Parse(Console.ReadLine());

            if (a < b && b < c)
            {
                int y = 1;
                Console.WriteLine(y);
            }
            else if (a == b && b == c)
            {
                int y = 2;
                Console.WriteLine(y);
            }
            else if (b<a && a<c)
            {
                int y = 3;
                Console.WriteLine(y);
            }
            else if (c<a && a<b)
            {
                int y = 4;
                Console.WriteLine(y);
            }
            else
            {
                int y = 0;
                Console.WriteLine(y);
            }
            


        }
        }   
            
            
                
    }        

