using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---> Animal Object <---\n");
            Animal obj = new Animal();
            obj.Greet();
            obj.Talk();
            obj.Sing();

            Console.WriteLine("\n---> Dog Object <---\n");
            Animal obj1 = new Dog();
            obj1.Greet();
            obj1.Talk();
            obj1.Sing();
        }
    }
}
