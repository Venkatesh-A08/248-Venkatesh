using System;
using System.Collections;

namespace EG_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue mystack = new Queue();
            mystack.Enqueue("Hello");
            mystack.Enqueue(1);
            mystack.Enqueue(2);
            mystack.Enqueue(3);
            mystack.Enqueue(4);

            foreach (var item in mystack)
                Console.WriteLine(item);
        }
    }
}
