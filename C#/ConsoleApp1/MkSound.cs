using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Product : IProduct
    {
        public void GetProName()
        {
            Console.WriteLine("Product Name = LapTop");
        }
        public void GetProPrice()
        {
            Console.WriteLine("Price = 50000");
        }
    }
}
