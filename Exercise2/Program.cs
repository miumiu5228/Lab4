using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point { X = 10, Y = 20 };

            List<Point> Square = new List<Point>
            {
                new Point {X = 10, Y = 20},
                new Point {X = 20, Y = 30},
                new Point {X = 30, Y = 40},

            };

            
            Customer customer = new Customer(1) { Name = "Ling", City = "Santa Clara" };
            Console.WriteLine(customer);
            

            static List<Customer> CreateCustomers()
            {
                return new List<Customer>
            {
                new Customer(1) { Name = "Hedy", City = "Taiwan"},
                new Customer(1) { Name = "Ming", City = "China" },
                new Customer(1) { Name = "Miumiu", City = "Mars" },



            };

            }


            List<Customer> customers = CreateCustomers();
            Console.WriteLine("Cutomers:\n");
            foreach (Customer c in customers)
                Console.WriteLine(c);
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
