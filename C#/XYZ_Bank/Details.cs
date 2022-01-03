using System;
using System.Collections.Generic;
using System.Text;

namespace XYZ_Bank
{
    public class Details
    {
        public Details()
        {
            Console.WriteLine("\n---Wellcome to XYZ Bank---\n");
        }
        public virtual void ACC_Name()
        {
            Console.WriteLine("Hii Dear Customer\n");
        }
    }

    public class Customer : Details
    {
        public Customer()
        {
            Console.WriteLine("\n--->Customer Details<---\n");
        }
        public override void ACC_Name()
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Hii Dear {0}", name);
        }
    }
}
