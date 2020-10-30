using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateNumbers_OOP
{
    class Add
    {
        private int x;
        private int y;

        public Add(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

       public void PrintAdd()
        {
            Console.WriteLine(this.x+this.y);
        }
    }
}
