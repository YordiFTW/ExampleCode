using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Anonymous_Methods_vs.Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> func = delegate(int i) { return i > 5; };
            Console.WriteLine(func(3));
            Console.WriteLine(func(7));
        }
    }
}
