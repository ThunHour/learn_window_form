using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleAppCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array list in c#

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(2);
            //arrayList.Add("hello");

            //for(int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            // dictionary in c# is hashtable
            //Console.WriteLine("Dictionary");
            //Hashtable wordList=new Hashtable();
            //wordList.Add("A","Apple");
            //wordList.Add("B", "Book");
            //wordList.Add("C", "Cat");
   
            //if (wordList.ContainsValue("Cat"))
            //{
            //    wordList.Remove("C");
            //}
            //wordList.Add("D", "Dog");
            //foreach(string word in wordList.Values)
            //{
            //    Console.WriteLine(word);
            //}

            //using linQ to get data from arraylist or hastable

            ArrayList arr=new ArrayList();
            arr.Add("apple");
            arr.Add("App");
            arr.Add("Book");
            arr.Add("dog");
            arr.Add("april");
            arr.Add("cat");
            arr.Add("blue");

            arr.Add("black");

            //arr.Add(60);
            //arr.Add(10);
            //arr.Add(100);
            //arr.Add(20);
            //arr.Add(40);
            //arr.Add(30);
            //arr.Add(50);
            //arr.Add(200);
            var list = from string s in arr where s.StartsWith("a") select s;
            foreach(string item in list.ToList())
            {
                Console.WriteLine(item);
            }
          

            Console.ReadKey();
        }

    }
}
