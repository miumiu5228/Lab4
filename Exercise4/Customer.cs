using System;
using System.Collections.Generic;

namespace Exercise4
{
    public static class Extensions
    {
        public static bool Compare(Customer customer1, Customer customer2)
        {
            if(customer1.CustomerId == customer2.CustomerId && customer1.Name == customer2.Name && customer1.City == customer2.City)
            {
                return true;
            }

            return false;

        }
    }


    public class Customer
    {

        static void Main(string[] args)
        {


            var customers = CreateCustomers();
            var newCusotmer = new Customer(10)
            {

                Name = "Hedy",
                City = "Tainan"
            };

            foreach (var c in customers)
            {
                if (Extensions.Compare(newCusotmer, c))
                {
                    Console.WriteLine("The new customer was already in the list");
                    return;

                }
            }

            Console.WriteLine("The new customer was not in the list");
        }

        static List<Customer> CreateCustomers()
        {
            return new List<Customer>()
            {
                new Customer(1) {Name = "Ling", City = "Santa Clara"},
                new Customer(2) {Name = "Yuyu", City = "Taipei"},
               
            };

        }
        public int CustomerId { get; private set; }

        public Customer(int id)
        {
            CustomerId = id;
        }

        public string Name { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return "My name is " + Name + ", I live in " + City;
        }
    }
}
