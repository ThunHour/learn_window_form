using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculateN_
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial _Factorial = new Factorial(5);
           
            Console.WriteLine(_Factorial.getFactorialNumber().ToString());
            Console.ReadKey();
        }
        public class Factorial
        {
            private int n;
          
            public Factorial(int n)
            {
                this.n = n;
            }
            public long getFactorialNumber()
            {
                long Mutiplyer = 1;
                if (n < 0)
                {
                    return 1;
                }
                for (int i = 1; i <= n; i++)
                {
                    Mutiplyer *= i;
                }
                return Mutiplyer;

            } 
        }
    }
}
