using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] MyStudentList = new String[5];
            MyStudentList[0] = "kimhour";
            MyStudentList[1] = "china";
            MyStudentList[2] = "chomreoun";
            MyStudentList[3] = "heng";
            MyStudentList[4] = "sovan";
            foreach (string name in MyStudentList)
            {
                Console.WriteLine(name);
            }
             string getSpace(int n)
            {
                string space = "";
                for(int i=0; i < n; i++)
                {
                    space += " ";
                }
                return space;
            }
            for(int i = 0; i < 10;i++)
            {
                Console.WriteLine(getSpace(i) +"*");
            }

           

            //to sort array
            Array.Sort(MyStudentList);
            foreach (string name in MyStudentList)
            {
                Console.WriteLine(name);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(getSpace(i) + "*");
            }
            // reverse array
            Array.Reverse(MyStudentList);
            foreach (string name in MyStudentList)
            {
                Console.WriteLine(name);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(getSpace(i) + "*");
            }
            String[] temp = new string[MyStudentList.Length+1];
            Array.Copy(MyStudentList, temp,MyStudentList.Length);
            MyStudentList = temp;
            temp = null;
            MyStudentList[5] = "Seiha";
            foreach (string name in MyStudentList)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();

        }

    }
}
