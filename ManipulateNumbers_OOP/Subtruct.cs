using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateNumbers_OOP
{
    class Subtruct
    {
        int x;
        int y;

        public Subtruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintSubtruct()
        {
            Console.WriteLine(this.x - this.y);
        }
    }
}
