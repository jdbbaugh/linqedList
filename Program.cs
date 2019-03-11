using System;
using System.Collections.Generic;
using System.Linq;

namespace linqedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>(){"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> LFruits = from fruit in fruits
                where fruit[0] == 'L'
                select fruit;
            foreach(string fruit in LFruits) {

            Console.WriteLine(fruit);
            }
        }
    }
}
