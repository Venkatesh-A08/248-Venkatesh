using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("This is a  Animal Constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal Greet Method");
        }
        public virtual void Talk()
        {
            Console.WriteLine("Animal virtual Talk Method");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal Sing virtual Method");
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("This is a Dog Constructor ");
        }
        public override void Sing()
        {
            Console.WriteLine("This is Dog Sing Override Method ");
        }
        public override void Talk()
        {
            Console.WriteLine("This is Dog Talk Override Method");
        }
    }
}
