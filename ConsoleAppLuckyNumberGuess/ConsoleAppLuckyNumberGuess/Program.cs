
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLuckyNumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number=0;
            string[] resultGuess = { "Very Good","Good","Normal","Bad"};
            string inputNumber;
            byte testNumber ;
            Console.Write("Please input your phone number': ");
            inputNumber = Console.ReadLine();
            foreach (char aNumber in inputNumber)
            {
                number=number += byte.Parse(aNumber.ToString());
               
            }
            testNumber = (byte)(number % 10);
            if (testNumber == 9)
            {
                Console.WriteLine(resultGuess[0]);
            } else if (testNumber >= 8 && testNumber < 9)
            {
                Console.WriteLine(resultGuess[1]);
            } else if (testNumber == 7) 
            {
                Console.WriteLine(resultGuess[2]);
            
            }
            
            else{
           
                Console.WriteLine(resultGuess[3]);
            }
        

            Console.ReadKey();

            

        }
    }
}
