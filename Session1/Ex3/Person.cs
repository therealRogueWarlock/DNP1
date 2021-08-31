using System;

namespace Ex3
{
    public class Person
    {

        public string Name { get; set;}
        
        public void Introduce()
        {
            Console.WriteLine($"hi, I Am {Name}");
        }

    }
}