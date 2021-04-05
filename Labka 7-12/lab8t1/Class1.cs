using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8t1
{
     class TTriangle
    {
        public double AB;
        public double AC;
        public double BC;
        public double k;

        TTriangle()
        {
            this.AB = 0;
            this.AC = 0;
            this.BC = 0;
        }
        public TTriangle(double AB, double AC, double BC)
        {
            this.AB = AB;
            this.AC = AC;
            this.BC = BC;
        }
        public TTriangle(TTriangle text)
        {
            this.AB = text.AB;
            this.AC = text.AC;
            this.BC = text.BC;
        }
        public double perimeterTriangle()
        {
            double P = AB + BC + AC;
            return P;
        }
        public double areaTriangle()
        {
            double p = perimeterTriangle() / 2;
            double S = Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
            return S;
        }
        public string seedsTriangle()
        {
            return $"AB: {AB}, AC:{AC}, BC:{BC}";
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
        public static TTriangle operator + ( TTriangle triangle,TTriangle randTriangle)
        {
            return new TTriangle(triangle.AB + randTriangle.AB,triangle.AC+randTriangle.AC,
                triangle.BC+randTriangle.BC);
        }
        public static TTriangle operator -(TTriangle triangle, TTriangle randTriangle)
        {
            return new TTriangle(triangle.AB - randTriangle.AB, triangle.AC - randTriangle.AC,
                triangle.BC - randTriangle.BC);
        }
        public static TTriangle operator *(TTriangle triangle, double k)
        {
            return new TTriangle(triangle.AB * k, triangle.AC * k,
                triangle.BC * k);
            

        }
}
}
