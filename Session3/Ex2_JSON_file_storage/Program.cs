using System;
using System.Collections.Generic;
using System.Threading.Channels;
using Ex1;

namespace Ex2_JSON_file_storage
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Frederik", "Marker", 22, 180, false, 'M', new[] {"Nothing", "nothing"});
            Person p2 = new Person("Sander", "Kirchert", 26, 182, false, 'M', new[] {"Motorcross", "Coding"});
            Person p3 = new Person("Sebastian", "Thomsen", 24, 190, false, 'M', new[] {"Gymnastics", "Wowe"});

            List<Person> persons = new();
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            PersonPersistence.StoreObjects(persons);
            PersonPersistence.ReadPersonJSON("MyPersons.txt").ForEach(person => Console.WriteLine(person.FirstName));


        }
    }
}