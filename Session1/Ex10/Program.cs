using System;
using System.Linq;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(BigDiff(new []{3,5,6,10}));
            Console.WriteLine(BigDiff(new []{2,7,9,10}));
            Console.WriteLine(BigDiff(new []{9,10}));
            
        }

        public static int BigDiff(int[] ints)
        {
            return ints.Max() - ints.Min();
            

        }
        
    }
}