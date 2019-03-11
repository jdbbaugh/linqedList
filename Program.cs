﻿using System;
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
            Console.WriteLine();
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 ==0);

            foreach(int num in fourSixMultiples){
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine("Students in alphabetical.");

            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

        List<string> descend = (from name in names
            orderby name descending
            select name).ToList();

        foreach(string name in descend) {

            Console.WriteLine(name);
        }
        Console.WriteLine();
        Console.WriteLine("numbers Ascending");
        List<int> numbersAscend = new List<int> (from num in numbers
            orderby num ascending
            select num).ToList();
            foreach(int num in numbersAscend) {

            Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine("Output how many numbers are in the numbers list");

            Console.WriteLine(numbers.Count());

            Console.WriteLine();
            Console.WriteLine("add nums up in list");
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            Console.WriteLine(purchases.Sum());



        }
    }
}
