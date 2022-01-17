using System;

namespace _1_Exercise
{
    class Program
    {
        static void Main(string[]  args)
        {
            Department Dep = new Department();
            Department Emp = new Employee();

            int NumOfDep = Dep.GetNumberOfDep();
            for (int i = 1; i <= NumOfDep; i++)
            {
                Console.WriteLine("\tDepartment Name : {0}\n \tEmployee Name : {1}\n", Dep.GetDepName(), Emp.GetDepDetails());
            }
        }
    }
}
