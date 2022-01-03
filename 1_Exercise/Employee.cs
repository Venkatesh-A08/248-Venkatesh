using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Exercise
{
    class Employee : Department
    {
        public Employee()
        {
        }
        public override string GetDepDetails()
        {
            Console.WriteLine("\nAdd Employee Details\n");
            string x = GetFirstName() + " " + GetLastName();
            return x;
        }
        public string GetFirstName()
        {
            Console.WriteLine("\nEnter a First Name : ");
            string x = Console.ReadLine();
            return x;
        }
        public string GetLastName()
        {
            Console.WriteLine("\nEnter a Last Name : ");
            string x = Console.ReadLine();
            return x;
        }
    }
}
