using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1);
            customer.Name = "Ling";
            customer.City = "Santa Clara";
            Console.WriteLine(customer);
        }
    }
}
