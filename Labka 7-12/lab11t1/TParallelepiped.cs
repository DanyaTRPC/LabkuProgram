using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11t1
{
    public class TParallelepiped : TBody
    {

        public TParallelepiped(double a, double b, double r, double h, int n)
        {
            this.a = a;
            this.b = b;
            this.r = r;
            this.h = h;
            this.n = n;
        }

        public override double areaParallelepiped()
        {                       
           double P = n * ((a * b) + (a * h) + (b * h));
           return P;            
        }
    }
}
