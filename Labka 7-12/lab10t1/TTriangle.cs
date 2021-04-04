using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10t1
{
    public class TTriangle
    {
        public double a;
        public double b;
        public double c;


        public TTriangle()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public TTriangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public TTriangle(TTriangle text)
        {
            this.a = text.a;
            this.b = text.b;
            this.c = text.c;
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
        public string seedsTriangle()
        {
            return $"a: {a}, b:{b}, c:{c}";
        }
        public static TTriangle operator +(TTriangle triangle, TTriangle randTriangle)
        {
            return new TTriangle(triangle.a + randTriangle.b, triangle.c + randTriangle.a,
                triangle.b + randTriangle.c);
            TTriangle n1 = new TTriangle(triangle);
            TTriangle n2 = new TTriangle(randTriangle);
        }
        public static TTriangle operator -(TTriangle triangle, TTriangle randTriangle)
        {
            return new TTriangle(triangle.a - randTriangle.b, triangle.c - randTriangle.a,
                triangle.b - randTriangle.c);
            TTriangle m1 = new TTriangle(triangle);
            TTriangle m2 = new TTriangle(randTriangle);
        }
        public static TTriangle operator *(TTriangle triangle, double k)
        {
            return new TTriangle(triangle.a * k, triangle.b * k,
                triangle.c * k);


        }
        public class TTrianglePrizm : TTriangle
        {
            public double h;
            public TTrianglePrizm(double a, double b, double c, double h) : base(a,b,c)
            {
                this.h = h;
            }
            public double areaPrizm()
            {
                double p = (a + b + c) / 2;
                double V = (p * (p - a) * (p - b) * (p - c)) * h;
                return V;
            }
        }

    }
}

