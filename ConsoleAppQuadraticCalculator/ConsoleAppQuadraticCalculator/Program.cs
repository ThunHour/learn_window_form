using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQuadraticCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            // declear variable 
            double a = 0.0f;
            double b = 0.0f;
            double c = 0.0f;
            double delta = 0.0f;
            double X1 = 0.0f;
            double X2 = 0.0f;

            Console.WriteLine("Please help to input as the following the formula aX^2 + bX + c = 0: \n-Coefficient Of X Square as a \n-Coefficient Of X as b \n-Constant as c");
            //prepare input

            Console.Write("Please help to input a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Please help to input b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Please help to input c: ");
            c = double.Parse(Console.ReadLine());

            // Calculate delta

            delta = (b * b) - 4 * (a * c);
            if (delta < 0)
            {
                Console.WriteLine("the roots do not exist, or the roots are imaginary because delta is less then zero.");
            }
            else
            {
                if (a < 0)
                {
                    Console.WriteLine("X1 and X2 are undefined because Coefficient Of X Square (a=0) is equal zero....!!!!! ");
                }
                else
                {
                    //Calculate first root
                    X1 = (-b - Math.Sqrt(delta)) / (2 * a);

                    //Calculate second root
                    X2= (-b + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("The value of Delta:"+delta.ToString());
                    Console.WriteLine("The value of first root X1="+X1.ToString());
                    Console.WriteLine("The value of second root X2="+X2.ToString());

                }
            }
            Console.ReadKey();

        }
    }
}
