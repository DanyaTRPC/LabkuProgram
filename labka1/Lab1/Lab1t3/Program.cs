using System;

namespace Lab4t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x1=");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine(x1);
            Console.WriteLine("y1=");
            float y1 = float.Parse(Console.ReadLine());
            Console.WriteLine(y1); 
            Console.WriteLine("x2=");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine(x2);
            Console.WriteLine("y2=");
            float y2 = float.Parse(Console.ReadLine());
            Console.WriteLine(y2); 
            Console.WriteLine("x3=");
            float x3 = float.Parse(Console.ReadLine());
            Console.WriteLine(x3); 
            Console.WriteLine("y3=");
            float y3 = float.Parse(Console.ReadLine());
            Console.WriteLine(y3);
            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            if (Math.Pow(AB, 2) > Math.Pow(AC, 2) + Math.Pow(BC, 2) || Math.Pow(AC, 2) > Math.Pow(AB, 2) + Math.Pow(BC, 2) || Math.Pow(BC, 2) > Math.Pow(AC, 2) + Math.Pow(AB, 2))
            {
                Console.WriteLine("Трикутник тупокутній");
            }
            else
            {
                Console.WriteLine("Трикутний не буде тупокутнім");
                }
            
        }   
    }
}
