using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenPrinter(10);
            UnevenPrinter(10);
            DivisiblePrinter(20,4);
        }

        static void UnevenPrinter(int upper)
        {
            DivisiblePrinter(upper,1);
        }
        
        static void EvenPrinter(int upper)
        {
            
            DivisiblePrinter(upper,2);
            
            
        }
        
        static void DivisiblePrinter(int upper, int divisor)
        {
            
            for (int i = 1; i < upper; i++)
            {
                if (i % divisor == 0)
                { 
                    Console.WriteLine(i);
                }
            }
            
        }
        
    }
    
    
    
}