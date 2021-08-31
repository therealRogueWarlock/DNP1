using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SurroundWord("<<ssaabb>>","yay"));
        }
        
        public static string SurroundWord(string surrounding, string word)
        {

            string returnString = "";
                
            for (int i = 0; i < surrounding.Length; i++)
            {
                if (i == surrounding.Length / 2) returnString += word;
                
                returnString += surrounding[i];
            }

            return returnString;



        }

    }
}