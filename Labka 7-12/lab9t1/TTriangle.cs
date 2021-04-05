using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9t1
{
    class TTriangle
    {
        public double a;
        public double b;
        public double c;
        public double k;

        
        public TTriangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        TTriangle()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public TTriangle(TTriangle text)
        {
            this.a = text.a;
            this.b = text.b;
            this.c = text.c;
        }
        public double A
        {
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                
            }
            get { return a; }
        }
        public double B
        {
            set
            {
                if (value > 0)
                {
                    b = value;
                }
            }
            get { return b; }
        }
        public double C
        {
            set
            {
                if (value > 0)
                {
                    c = value;
                }
            }
            get { return c; }
        }

        public string seedsTriangle()
        {
            return $"a: {a}, b:{b}, c:{c}";
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
        public string comparisonTriangle(TTriangle otherTriangle)
        {
            if (perimeterTriangle() == otherTriangle.perimeterTriangle())
            {
                return "Трикутники рівні";
            }
            else
            {
                return "Трикутники не рівні";
            }
        }
        public static TTriangle operator +(TTriangle triangle, TTriangle randTriangle)
        {
            return new TTriangle(triangle.a + randTriangle.a, triangle.b + randTriangle.b,
                triangle.c + randTriangle.c);
            TTriangle n1 = new TTriangle(triangle);
            TTriangle n2 = new TTriangle(randTriangle);
        }
        public static TTriangle operator -(TTriangle triangle, TTriangle randTriangle)
        {
            return new TTriangle(triangle.a - randTriangle.a, triangle.b - randTriangle.b,
                triangle.c - randTriangle.c);
            TTriangle m1 = new TTriangle(triangle);
            TTriangle m2 = new TTriangle(randTriangle);
        }
        public static TTriangle operator *(TTriangle triangle, double k)
        {
            return new TTriangle(triangle.a * k, triangle.b * k,
                triangle.c * k);


        }
    }
}
