using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(5, 10);
            Rational r2 = new Rational(12, 6);
            Rational result = r1.Multiply(r2);
            Console.WriteLine(result);
        }
    }
}
