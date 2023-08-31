using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApprecursiveFunction
{
    class Factorial
    {

            private long _n;
            public Factorial() { }
            public Factorial(long n)
            {
                this._n = n;
            }

            public long N { get => _n; set => _n = value; }
            public long getFactorialNumber()
            {
                return getFactorialNumberOf(_n);
            }
            public long getFactorialNumberOf(long n)
            {
                if (n == 0)
                {
                    return 1;
                }
                return getFactorialNumberOf(n - 1) * n;
            }
    }
}
