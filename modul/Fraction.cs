using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul
{
    public class Fraction
    {
        public int numerator;
        public int denominator;

        Fraction()
        {
            this.numerator = 0;
            this.denominator = 0;
            
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public Fraction(Fraction text)
        {
            this.numerator = text.numerator;
            this.denominator = text.denominator;
        }
        public int abbreviation()
        {
            int abb = 0;
            if (numerator == denominator)
            {
                int abb1 = numerator / denominator;
                

            }
            return abb;

        }
        public static Fraction operator + (Fraction numerator, Fraction denominator)
        {
            return new Fraction(
                numerator / denominator + numerator / denominator
                );
        }
        public static Fraction operator -(Fraction numerator, Fraction denominator)
        {
            return new Fraction(
                numerator/ denominator - numerator/denominator
                );
        }
        public static Fraction operator *(Fraction numerator, Fraction denominator)
        {
            return new Fraction(
                numerator / denominator * numerator / denominator
                );
        }
        public static Fraction operator /(Fraction numerator, Fraction denominator)
        {
            return new Fraction(
                numerator / denominator / numerator / denominator
                );
        }





    }
}
