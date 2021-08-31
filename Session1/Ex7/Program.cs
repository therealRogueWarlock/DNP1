using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeAbba("hi", "bye"));
            Console.WriteLine(MakeAbba("yo","alice"));
            Console.WriteLine(MakeAbba("what","up"));
        }
        
        public static string MakeAbba(string a, string b)
        {
            return $"{a}{b}{b}{a}";

        }
        
    }
    
    
}