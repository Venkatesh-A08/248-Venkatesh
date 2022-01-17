using System;
using System.Collections.Generic;
using System.Linq;

namespace ForPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EmployeeContext())
            {
                List<EmployeeDetails> Emp = context.EmployeeDetails.ToList();

                foreach (var Employee in Emp)
                {
                    Console.WriteLine("| {0,10} | {1,10} |", Employee.FirstName, Employee.Salary);
                }
            }
        }
    }
}
