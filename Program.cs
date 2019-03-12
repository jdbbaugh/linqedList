using System;
using System.Collections.Generic;
using System.Linq;

namespace linqedList
{
    class Program
    {
        public class Customer
{
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
}
        class BanksWithMills {
            internal string BankName {get; set;}
            internal double BankNum {get; set;} = 0;
        }
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

        Console.WriteLine();
        Console.WriteLine("show most expensive product");
        List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

        Console.WriteLine(prices.Max());

        Console.WriteLine();
        Console.WriteLine("list of not square values from whereSquaredo");

        List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
        var notSquare = wheresSquaredo.TakeWhile(num => Math.Round(Math.Sqrt(num), 2) * Math.Round(Math.Sqrt(num), 2) != num);


        foreach(int num in notSquare){
            Console.WriteLine(num);
        }

        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };
        Console.WriteLine();
        Console.WriteLine("Show millionaires");

        List<Customer> millionaires = (from million in customers
            where million.Balance >= 1000000.00
            select million).ToList();

        foreach(Customer richPerson in millionaires) {
            Console.WriteLine($"{richPerson.Name} is a Millionaire");
        }

        Console.WriteLine();
        Console.WriteLine("Show millionaires Per Bank");

        List<BanksWithMills> bankreport = (from kid in customers
            group kid by kid.Bank into bankGroup
            select new BanksWithMills{
                BankName = bankGroup.Key,
                BankNum = bankGroup.Count(num => num.Balance >= 1000000)
            }).ToList();

        foreach(BanksWithMills bank in bankreport){
            Console.WriteLine($"{bank.BankName} has {bank.BankNum}");
        }



        }
    }
}
