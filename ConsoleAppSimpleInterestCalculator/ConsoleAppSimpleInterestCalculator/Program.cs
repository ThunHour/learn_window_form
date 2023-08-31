using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSimpleInterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declear variable
            int Principle = 0;
            float InterestRatePerYear = 0.0f;
            float TimesYear = 0.00f;
            float InterestEarned = 0.0f;
            float TotalAmountPaid = 0.0f;
            Console.WriteLine("=== Welcome to Simple Interest Calculator:");

            // Prepare input
            Console.WriteLine("PLease help to input as the following: \n -Principle \n -Interest Rate per Year \n -Time as Yearly");

            Console.Write("Please input Preciple: ");
            Principle = int.Parse(Console.ReadLine());

            Console.Write("Please input Interest per annum: ");
            InterestRatePerYear = float.Parse(Console.ReadLine());

            Console.Write("Please input Time as yearly: ");
            TimesYear = float.Parse(Console.ReadLine());

            // Read all input 

            // To calculate Interestearned and Total amount to be paid
            InterestEarned = Principle * (InterestRatePerYear / 100) * TimesYear;
            TotalAmountPaid = Principle + InterestEarned;
            Console.WriteLine("Interest Earned :" + InterestEarned.ToString("C"));
            Console.WriteLine("Total Amound paid after the given period:"+TotalAmountPaid.ToString("C"));

            Console.ReadKey();
        }
    }
}
