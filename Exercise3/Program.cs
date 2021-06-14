using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void VarTest()
        {
            var i = 28;
            var s = "Test...";
            var numbers = new [] { 2, 3, 4, 5 };

             var complex = new SortedDictionary<string, List<DateTime>>();

        }
        static void Main(string[] args)
        {
            var customers = CreateCustomers();
            Console.WriteLine("Customers:\n");
            foreach (var c in customers)
                Console.WriteLine(c);
        }

        static List<Program> CreateCustomers()
        {
            return new List<Program>()
            {
                new Program {Name = "Ling", City = "Santa Clara"},
                new Program {Name = "Yuyu", City = "Taipei"}
            };

        }

    }

    class Program
    {
        public string Name { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return "My name is " + Name + ", I live in " + City;
        }
    }
}
