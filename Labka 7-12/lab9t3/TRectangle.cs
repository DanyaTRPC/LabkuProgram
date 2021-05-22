using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9t3
{
    class TTriangle
    {
        public double a;
        public double b;
        public double c;
        public double P;
        public double S;
        public TTriangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double perimeterTriangle()
        {
            double P = a + b + c; 
            return P; 
        }
        public double areaTriangle()
        {
            double p = perimeterTriangle() / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
            return S; 
        }
        public string seedsTriangle()
        {
            return $"a: {a}, b:{b}, c:{c}";
        }
    }
}
