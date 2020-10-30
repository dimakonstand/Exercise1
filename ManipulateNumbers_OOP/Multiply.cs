using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateNumbers_OOP
{
    class Multiply
    {
        int x;
        int y;

        public Multiply(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintMultiply()
        {
            Console.WriteLine(this.x * this.y);
        }
    }
}
