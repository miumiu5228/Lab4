using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise5
{
    public static class Extensions
    {
        public static List<K> FilterBy<K,V>(
            this Dictionary<K, V> items,
            KeyValueFilter<K, V> filter)
        {
            var result = new List<K>();
            foreach (KeyValuePair<K, V> element in items)
            {
                if (filter(element.Key, element.Value))
                    result.Add(element.Key);
            }
            return result;
        }
    }
    class Program
    {
        public delegate bool KeyValueFilter<K, V>(K key, V value);
        static void Main(string[] args)
        {
            var customers = CreateCustomers();

            foreach (var c in FindCustomersByCity(customers, "Taipei"))
                Console.WriteLine(c);

            var customerDictionary = new Dictionary<Customer, string>();

            foreach (var c in customers)
                customerDictionary.Add(c, c.Name.Split(' ')[1]);

            var matches = customerDictionary.FilterBy(
                (Customer, lastName) => lastName.StartsWith("A"));
            Console.WriteLine("Number of Matches: {0}", matches.Count);
        }

        public static List<Customer> FindCustomersByCity(List<Customer> customers, string city)
        {
            return customers.FindAll(c => c.City == city);

        }

        static List<Customer> CreateCustomers()
        {
            return new List<Customer>()
            {
                new Customer(1) {Name = "Ling", City = "Santa Clara"},
                new Customer(2) {Name = "Yuyu", City = "Taipei"},

            };

        }

    }
    class Customer
    {
        

       

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
