using System;

namespace revString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Venkat";
            char[] myArr = text.ToCharArray();
            Array.Reverse(myArr);
            Console.WriteLine(myArr);
        }
    }
}
