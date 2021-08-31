using System;
using System.Collections;

namespace MathLib
{
    public class Calculator
    {


        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Add(int[] integers)
        {
            int sum = 0;
            foreach (var VARIABLE in integers) {
                sum += VARIABLE;
            }
            return sum;
        }

        public static int ComparerNumbers(int x, int y)
        {
        
            if (x > y) return x;
            return y;
        }
        
    }
}