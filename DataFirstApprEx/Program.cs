using System;
using System.Collections.Generic;
using System.Linq;

namespace DataFirstApprEx
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                List<Department> det = context.Department.ToList();

                foreach (var details in det)
                {
                    Console.WriteLine("| {0,10} | {1,10} |", details.DepartmentName, details.Location);
                }
            }
        }
    }
}
