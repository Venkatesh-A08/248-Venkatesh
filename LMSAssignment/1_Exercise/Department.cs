using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Exercise
{
    class Department
    {
        public Department()
        {
            
        }
         public string GetDepName()
        {
            Console.WriteLine("Enter a Department Name : ");
            string DepName = Console.ReadLine();
            return DepName;
        }
        public int GetNumberOfDep()
        {
            Console.WriteLine("Enter a Number of Department : ");
            string NumberOfDep =Console.ReadLine();
            return Int16.Parse(NumberOfDep);
        }
        public virtual string GetDepDetails()
        {
            Console.WriteLine("Check the Department Details");
            Console.WriteLine("<---Enter to continue--->");
            string x = Console.ReadLine();
            return x;
        }
    }
}
