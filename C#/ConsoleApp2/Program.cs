using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData obj = new TestData();
            
            Console.WriteLine("{0},{1}",obj.Add(1,2),obj.Add(1,2,3));
        }
    }
}
