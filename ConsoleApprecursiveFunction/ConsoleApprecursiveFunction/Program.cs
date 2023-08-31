using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApprecursiveFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorialCalcutor = new Factorial();
            Console.Write("Input the N: ");
            factorialCalcutor.N = long.Parse(Console.ReadLine()); ;
            Console.WriteLine(factorialCalcutor.getFactorialNumber().ToString());
            Console.ReadKey();
        }
       

    }
}
