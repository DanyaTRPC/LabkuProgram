using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11t1
{
    public class TBody
    {
        public double a;
        public double b;
        public double r;
        public double h;
        public double n;

        public TBody()
        {
            this.a = 0;
            this.b = 0;
            this.r = 0;
            this.h = 0;

        }
        public TBody( double a, double b, double r, double h)
        {
            this.a = a;
            this.b = b;
            this.r = r;
            this.h = h;

        }

        public virtual double areaParallelepiped()
        {
            double S = (a * b + a * h + b * h);
            return S;
        }
        public virtual double capacityParallelepiped()
        {
            double V = a * b * h;
            return V;
        }
        public virtual double areaBall()
        {
            double S = 4*Math.PI * Math.Pow(r, 2);
            return S;
        }
        public virtual double capacityBall()
        {
            double V = (4 / 3) * Math.PI * Math.Pow(r, 3);
            return V;
        }
        

    }
}
