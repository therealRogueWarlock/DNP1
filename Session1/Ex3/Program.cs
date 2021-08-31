using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person
                {
                    Name = "bob"
                };
            
            person.Introduce();
            person.Name = "dillon";
            person.Introduce();
            
        }
    }
}