using System;
using MathLib;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = MathLib.Calculator.Add(5, 5);
            Console.WriteLine(result);
            int resultTwo = MathLib.Calculator.Add(new[] {3, 2, 1, 2, 3});
            Console.WriteLine(resultTwo);

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            

            int resultThree = Calculator.ComparerNumbers(x, y);
            Console.WriteLine(resultThree);
            
        }
        
        
        
        
    }
}