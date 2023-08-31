using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            khmer_to_english khmerword=new khmer_to_english("បាទ");
            Englich_to_khmer englishword = new Englich_to_khmer("Apple");
            DictionaryManager Dmgr=new DictionaryManager(khmerword);
            Dmgr.Display();
            Console.ReadKey();

        }
        //create interface
        public interface IDisplayable
        {
            void Display();
        }
        public class DictionaryManager
        {
            private IDisplayable word;
            public DictionaryManager() { }
            public DictionaryManager(IDisplayable w)
            {
                word = w;   
            }
            public void Display()
            {
                word.Display();
            }
        }
        public class Englich_to_khmer:IDisplayable
        {
            private string e_word ;
            private string kh_word;
            public Englich_to_khmer() { }
            public Englich_to_khmer(string eword) {
                this.e_word = eword;

            }

            public void Display()
            {
                Console.WriteLine(String.Format("English word {0} = {1}",e_word,kh_word));
            }
        }
        public class khmer_to_english : IDisplayable
        {
            private string e_word;
            private string kh_word;
            public khmer_to_english() { }
            public khmer_to_english(string eword)
            {
                this.e_word = eword;
            }

            public void Display()
            {
                Console.WriteLine(String.Format("Khmer word {0} = {1}", kh_word, e_word));
            }
        }
    }
}
