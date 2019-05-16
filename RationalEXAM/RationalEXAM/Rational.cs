using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalEXAM
{
    class Rational
    {
        public int Mehane { get; set; }
        public int Mone { get; set; }

        public Rational(int n1, int n2)
        {
            Mehane = n1;
            if (Mehane < 1)
                Mehane = 0;
            Mone = n2;
            if (Mone < 1)
                Mone = 0;
        }
        
        public bool GreaterThan(Rational r)
        {
            if (Mehane + r.Mone > Mone + r.Mehane)
                return true;
            else
                return false;
        }
        public bool Equals(Rational r)
        {
            if (Mehane + r.Mone == Mone + r.Mehane)
                return true;
            else
                return false;
        }
         public Rational Plus(Rational r)
        {
            return new Rational(Mehane + r.Mehane, Mone + r.Mehane + Mehane + r.Mone);
        }
        public Rational Minus(Rational r)
        {
            return new Rational(Mehane - r.Mehane, Mone - r.Mehane - Mehane - r.Mone);
        }
        public Rational Multiply(Rational r)
        {
            return new Rational(Mehane * r.Mehane, Mone * r.Mone);
        }
        public int GetNumerator(Rational r)
        {
            return r.Mehane;
        }
        public int GetDenomirator(Rational r)
        {
            return r.Mone;
        }
        public override string ToString()
        {
            return $"{Mehane}/{Mone}";
        }
    }
}
