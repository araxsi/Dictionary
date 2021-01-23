using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(1, "America");
            cities.Add(2, "Arnavutluk");
            cities.Add(3, "Almanya");
            cities.Add(4, "Avusturya");
            cities.Add(5, "Avusturya");
            cities.Add(6, "Azerbaycan");

            
            foreach (KeyValuePair<int, string> kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
        }

    }
}

