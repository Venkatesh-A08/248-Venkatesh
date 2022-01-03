using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            ABS obj = new ABSDrived();
            int add = obj.AddTwoNumbers(10,10);
            int sub = obj.SubTwoNumber(10, 5);
            Console.WriteLine("{0},{1}", add, sub);
        }
    }
}
