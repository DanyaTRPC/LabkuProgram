using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11t1
{
    class TBall : TBody
    {
        public TBall(double a, double b, double r, double h, int n)
        {
            this.a = a;
            this.b = b;
            this.r = r;
            this.h = h;
            this.n = n;

        }

        public override double areaBall()
        {
            double B = n * (4 * Math.PI * Math.Pow(r, 2));
            return B;
        }
    }
}
