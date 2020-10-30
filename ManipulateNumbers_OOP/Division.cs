using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateNumbers_OOP
{
    class Division
    {
        int x;
        int y;

        public Division(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

         public void PrintDivision()
        {
            if (y == 0) Console.WriteLine("You cant divide by zero!");
            else
            {
                double z;
                z = this.x / this.y;
                Console.WriteLine(z);
            }
        }
    }
}
