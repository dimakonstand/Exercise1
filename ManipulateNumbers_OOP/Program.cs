using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateNumbers_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide two integers ");
            string val = Console.ReadLine();
            int x = Convert.ToInt32(val);
            val = Console.ReadLine();
            int y = Convert.ToInt32(val);

            Add adder = new Add(x, y);
            Subtruct sub = new Subtruct(x, y);
            Division div = new Division(x, y);
            Multiply multi = new Multiply(x, y);
            adder.PrintAdd();
            sub.PrintSubtruct();
            div.PrintDivision();
            multi.PrintMultiply();

        }
    }
}
