using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10t1
{
    public class TTrianglePrizm : TTriangle
    {
        public double h;
        public TTrianglePrizm(double a, double b, double c, double h) : base(a, b, c)
        {
            this.h = h;
        }
        public double capacitPrizm()
        {
            double V = areaTriangle() * h;
            return V;
        }
        public double perimeterPrizm()
        {
            double Pp = perimeterTriangle() + perimeterTriangle() + (h * 3);
            return Pp;
        }
        public double areaPrizm()
        {
            double Sp = (perimeterTriangle() * h) + 2 * areaTriangle();
            return Sp;
        }
    }
}
