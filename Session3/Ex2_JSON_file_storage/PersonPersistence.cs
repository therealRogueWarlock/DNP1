using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Ex1;

namespace Ex2_JSON_file_storage
{
    public class PersonPersistence
    {


        public static void StoreObjects(List<Person> persons)
        {
            
            string jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions {WriteIndented = true});
            
            File.WriteAllText("MyPersons.txt", jsonFormatted);
            
            
        }

        public static List<Person> ReadPersonJSON(string path)
        {
            string text = File.ReadAllText("MyPersons.txt");

            List<Person> persons = JsonSerializer.Deserialize<List<Person>>(text);
            return persons;
        }
        
       
    }
}