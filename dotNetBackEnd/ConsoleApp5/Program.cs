using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthwindContext())
            {
                List<Customers> cus = context.Customers.ToList();

                foreach(var customer in cus)
                {
                    Console.WriteLine("| {0,10} | {0,10} |",customer.ContactName,customer.CompanyName);
                }
            }
        }
    }
}
