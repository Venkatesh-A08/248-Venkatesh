using System;
using System.Collections.Generic;
using System.Linq;


namespace DFAProj
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CustomersContext())
            {
                List<Customer> det = context.Customer.ToList();

                foreach (var details in det)
                {
                    Console.WriteLine("| {0,10} | {1,10} |", details.Name, details.Location);
                }
            }
        }
    }
}
