using System;
using System.Linq;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FirstNLast("hallo",2));
            Console.WriteLine(FirstNLast("Chocolate",3));
            Console.WriteLine(FirstNLast("Chocolate",1));

                        
        }


        public static string FirstNLast(string word, int n)
        {
            string returnWord = word.Remove(n);
            returnWord += word.Substring(word.Length - n);
            return returnWord;
        }
    }
}