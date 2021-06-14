using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        static void Query()
        {
            foreach(var c in CreateCustomers())
            {
                var customerStores = new
                {
                    c.City,
                    CustomerName = c.Name,
                    Stores = from s in CreateStores()
                             where s.City == c.City
                             select s
                };

                //Console.WriteLine("{0}\t{1}", customerStores.City, customerStores.CustomerName);

                //foreach (var store in customerStores.Stores)
                  //Console.WriteLine("\t<{0}>", store.Name);

                var results = from customer in CreateCustomers()
                              join s in CreateStores() on customer.City equals s.City
                              group s by customer.Name into g
                              let count = g.Count()
                              orderby count ascending
                              select new
                              {
                                
                                  CustomerName = g.Key, Count = count
                              };

                foreach (var r in results)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", r.CustomerName, r.Count);
                  
                }
                   

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

        static List<Customer> CreateCustomers()
        {
            return new List<Customer>()
            {
                new Customer(1) {Name = "Yuyu", City = "Santa Clara"},
                new Customer(2) {Name = "Ling", City = "Taipei"},

            };

        }

        public class Store
        {
            public string Name { get; set; }
            public string City { get; set; }
            public override string ToString()
            {
                return "My name is " + Name + ", I live in " + City;
            }

        }

        static List<Store> CreateStores()
        {
            return new List<Store>
            {
                new Store { Name = "Ling's Cafe", City = "Taipei"},
                new Store { Name = "Ming's Bookstore", City = "LA"},
                new Store { Name = "Yuyu's Flowers", City = "Tainan"},

            };
        }
        static void Main(string[] args)
        {
            Query();
        }
    }
}
