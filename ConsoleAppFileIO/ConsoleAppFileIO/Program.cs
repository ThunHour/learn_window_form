using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myfile = File.ReadAllText("D:/PycharmProjects/TUX/module_1/ConsoleAppFileIO/Text.txt");
            Console.WriteLine(myfile);
            bool isExist = File.Exists("D:/PycharmProjects/TUX/module_1/ConsoleAppFileIO/Text.txt");
            Console.WriteLine(isExist);
            FileInfo finIfo=new FileInfo("Text.txt");
            Console.ReadKey();
        }
    }
}
