using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaDES.DoiTuong
{
    public static class ModularArithmetic
    {
        public static BigInteger ModularInverse(BigInteger a, BigInteger n)
        {
            BigInteger t = 0;
            BigInteger newT = 1;
            BigInteger r = n;
            BigInteger newR = a;

            while (newR != 0)
            {
                BigInteger quotient = r / newR;
                BigInteger tempT = t;
                t = newT;
                newT = tempT - quotient * newT;
                BigInteger tempR = r;
                r = newR;
                newR = tempR - quotient * newR;
            }

            if (r > 1)
            {
                throw new ArgumentException("a is not invertible");
            }

            if (t < 0)
            {
                t += n;
            }

            return t;
        }
    }
}
