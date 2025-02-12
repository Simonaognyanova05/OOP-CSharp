using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalsNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace PoC
    {
        public class RationalNumber
        {
            private long num;
            private long denom;

            public RationalNumber()
            {
                num = 0;
                denom = 1;

                MakeCanonical();
            }

            public RationalNumber(long aNum, long aDenom)
            {
                num = aNum;
                denom = aDenom;

                MakeCanonical();
            }

            public static RationalNumber operator +(RationalNumber a,
                RationalNumber b)
            {
                var gcd = GCD(a.denom, b.denom);
                // denom2 = q*gcd
                // denom1 = v*gcd

                var newNum = a.num * (b.denom / gcd) + b.num * (a.denom / gcd);
                var newDenom = a.denom * (b.denom / gcd);

                return new RationalNumber(newNum, newDenom);
            }

            public static RationalNumber operator -(RationalNumber a)
            {
                return new RationalNumber(-a.num, a.denom);
            }

            public static RationalNumber operator -(RationalNumber a,
                RationalNumber b)
            {
                return a + (-b);
            }

            public static RationalNumber operator *(RationalNumber a,
                RationalNumber b)
            {
                // a/b * c/d = (a*c)/(b*d)
                // 3/2 * 1/3 = 3*1 / 2*3 
                // gcdAD, gcdBC
                // gcdAD*q/b * c/(gcdAD*v) = gcdAD*q*c / b*gcdAD*v =
                // (a/gcdAD)*c / b * (d/gcdAD)

                var gcd1 = GCD(a.num, b.denom);
                var gcd2 = GCD(a.denom, b.num);

                var newNum = (a.num / gcd1) * (b.num / gcd2);
                var newDenom = (a.denom / gcd2) * (b.denom / gcd1);

                return new RationalNumber(newNum, newDenom);
            }

            public static RationalNumber operator /(RationalNumber a,
                RationalNumber b)
            {
                return a * new RationalNumber(b.denom, b.num);
            }

            public static implicit operator RationalNumber(long a)
            {
                return new RationalNumber(a, 1);
            }

            public static explicit operator decimal(RationalNumber a)
            {
                return (decimal)a.num / a.denom;
            }

            public static explicit operator RationalNumber(decimal a)
            {
                // a = 2.05
                // (long)a = 2
                // 275 / 100
                long num = (long)a;
                long denom = 1;

                while (num != a)
                {
                    if (denom * 10m > long.MaxValue ||
                        num * 10m > long.MaxValue)
                        break;
                    num = (long)(a * 10);
                    a *= 10;
                    denom *= 10;
                }

                return new RationalNumber(num, denom);
            }

            public static bool operator ==(RationalNumber a,
                RationalNumber b)
            {
                return a.num == b.num && a.denom == b.denom;
            }

            public static bool operator <(RationalNumber a,
                RationalNumber b)
            {
                return (a - b).num < 0;
            }

            public static bool operator >(RationalNumber a,
                RationalNumber b)
            {
                return !(a < b) && !(a == b);
            }

            public static bool operator <=(RationalNumber a,
                RationalNumber b)
            {
                return !(a > b);
            }

            public static bool operator >=(RationalNumber a,
                RationalNumber b)
            {
                return !(a < b);
            }

            public override bool Equals(object obj)
            {
                var rn = obj as RationalNumber;
                if ((object)rn == null)
                    return false;

                return this == rn;
            }

            public override int GetHashCode()
            {
                return ToString().GetHashCode();
            }

            public static bool operator !=(RationalNumber a,
                RationalNumber b)
            {
                return !(a == b);
            }

            public override string ToString()
            {
                return string.Format("{0}/{1}", num, denom);
            }

            private static long GCD(long a, long b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);

                while (b != 0)
                {
                    var temp = b;
                    b = a % b;
                    a = temp;
                }

                return a;
            }

            private void MakeCanonical()
            {
                if (denom == 0)
                    throw new DivideByZeroException("x/0 is not a rational number");

                if (denom < 0)
                {
                    num = -num;
                    denom = -denom;
                }

                var gcd = GCD(num, denom);
                num /= gcd;
                denom /= gcd;

                if (num == 0)
                    denom = 1;
            }
        }
    }
}
