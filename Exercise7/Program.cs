using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise7
{
    public class Store
    {
        public string Name { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return "My name is " + Name + ", I live in " + City;
        }

    } 


    class Program
    {
        static void Main(string[] args)
        {
            Query();
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

        static void Query()
        {
            var stores = CreateStores();
            // foreach (var store in stores.Where(stores => stores.City == "Tainan"))
            //   Console.WriteLine(store);

            //IEnumerable<Store> results = from s in stores
            //where s.City == "Tainan"
            //select s;
            //foreach (var s in results)
            //    Console.WriteLine(s);

            var numTainan = stores.Count(s => s.City == "Tainan");
            Console.WriteLine("There are {0} stores in Tainan.", numTainan);
        }
    }
}
