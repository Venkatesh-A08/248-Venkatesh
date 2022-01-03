using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class ABS 
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
        public abstract int SubTwoNumber(int a, int b);
    }
    class ABSDrived : ABS
    {
        public override int SubTwoNumber(int a, int b)
        {
            return a - b;
        }
    }
}
